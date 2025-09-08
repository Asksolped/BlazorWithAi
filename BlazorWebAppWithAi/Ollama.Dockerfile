# ./Dockerfile
FROM ollama/ollama

RUN apt-get update && apt-get install -y curl nginx && rm -rf /var/lib/apt/lists/*

COPY BlazorWebAppWithAi/ollama-entrypoint.sh /ollama-entrypoint.sh
COPY BlazorWebAppWithAi/ollama_nginx.conf /etc/nginx/nginx.conf

RUN chmod +x /ollama-entrypoint.sh

ENTRYPOINT ["/bin/sh","/ollama-entrypoint.sh"]