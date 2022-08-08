1. Dockerizing a Node.js web app
https://nodejs.org/en/docs/guides/nodejs-docker-webapp/

docker build . -t eladt/node-web-app -t eladt/node-web-app:latest -t eladt/node-web-app:1.0.0
docker run -p 49160:8080 -d eladt/node-web-app
docker ps
docker logs <container id>
docker exec -it <container id> /bin/bash
docker kill <container id>

2. Push your first image to your Azure container registry using the Docker CLI
https://docs.microsoft.com/en-us/azure/container-registry/container-registry-get-started-docker-cli?tabs=azure-cli

az login
az acr login --name crmaincontregistry 
#docker login crmaincontregistry.azurecr.io
docker tag eladt/node-web-app crmaincontregistry.azurecr.io/eladt/node-web-app
#docker tag eladt/node-web-app crmaincontregistry.azurecr.io/eladt/node-web-app:latest
docker push crmaincontregistry.azurecr.io/eladt/node-web-app


3. DevOps - build & Push

4. App Service - CI/CD
5. Container App
6. AKS