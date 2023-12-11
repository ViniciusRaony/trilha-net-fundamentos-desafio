#!/bin/bash
IMAGE_NAME=desafiofundamentos

# build Docker image
docker build -t $IMAGE_NAME .

# run docker imnagem Docker
docker run -it --rm $IMAGE_NAME

