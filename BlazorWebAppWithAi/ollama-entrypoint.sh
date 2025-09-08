#!/bin/sh
set -eu

# clear ready flag
rm -f /tmp/ready

# start ollama
ollama serve &

# wait for it to serve
echo "Starting Ollama..."
until curl -s http://localhost:11434 > /dev/null; do
  sleep 1
done

# models to install
MODELS="gemma3:1b"

# pull and install models, or skip if present
for MODEL in $MODELS; do
  if ! ollama list | grep -q "$MODEL"; then
    echo "⚡️ Pulling model: $MODEL"
    ollama pull "$MODEL"
  else
    echo "⛳️ Model '$MODEL' already present."
  fi
done

# set container as ready
touch /tmp/ready

# start nginx in foreground (PID 1)
exec nginx -g "daemon off;"