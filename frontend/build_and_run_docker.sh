#!/bin/bash

echo "Starting to build..."

docker build -t vuejs/dockerize-vuejs-app .

echo "Starting to run..."

docker run -it -p 8080:80 --rm vuejs/dockerize-vuejs-app 

