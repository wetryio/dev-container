# Simple project to test dev container

## Prerequite

* Docker
* vscode
* https://github.com/Microsoft/vscode-remote-release

## How it works

The very very basic is not explained here. The Microsoft tutorial is quite well made. Thanks Microsoft.

First, vscode use docker-compose to up 2 new containers. One for development, second for mariadb.
DB is setted by using both docker-compose, and a file contained in .dev/initmaria. this file is run the very first run as explained in doc here : [https://hub.docker.com/_/mariadb](https://hub.docker.com/_/mariadb)

Then, vscode is installing requested extension, from .devcontainer/devcontainer.json. It also run the migrations files from postCreateCommand property.

```text
there is a known bug remote container using docker-compose instead of dockerfile.
Container is started, stopped (because there is nothing todo), then vscode try to connect. It fail for sure.
To prevent it, the line  command: sleep infinity  is used.
```

By using extension Rest Client you can try to POST and GET the todos with files from http directory.


### Notes

this repository is not made to demonstrate very well c# design. The only target is the use of remote-container extension with a ready to use LOCAL/DEV environment.