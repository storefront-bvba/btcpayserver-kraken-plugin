#!/bin/bash
set -e



# Change this var for your plugin...
PLUGIN_DIR=Custodians.Kraken






# Now do the work...
DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
cd "$DIR"

PLUGIN_PROJECT=BTCPayServer.Plugins.$PLUGIN_DIR

echo "Preparing tmp dir..."
rm -Rf tmp
mkdir tmp
cd tmp

echo "Cloning master..."
git clone --depth 1 https://github.com/btcpayserver/btcpayserver.git btcpayserver
cd btcpayserver

echo "Moving plugin into position..."
rsync -av --exclude .git --exclude tmp "$DIR"/* ./Plugins/$PLUGIN_PROJECT

echo "Adding reference..."
cd BTCPayServer
dotnet add reference ../Plugins/$PLUGIN_PROJECT
cd ..


cd Plugins/$PLUGIN_PROJECT

PUBL=bin/publish
DIST=bin/packed

rm -rf $DIST/*
dotnet publish -c Release -o $PUBL/$PLUGIN_PROJECT
dotnet run --project ../../BTCPayServer.PluginPacker $PUBL/$PLUGIN_PROJECT $PLUGIN_PROJECT $DIST



echo "DONE!"
