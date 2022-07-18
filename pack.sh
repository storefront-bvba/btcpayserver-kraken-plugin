#!/bin/bash

PUBL=bin/publish
DIST=bin/packed

rm -rf $DIST/*
dotnet publish -c Release -o $PUBL/BTCPayServer.Plugins.Custodians.Kraken
dotnet run --project ../../BTCPayServer.PluginPacker $PUBL/BTCPayServer.Plugins.Custodians.Kraken BTCPayServer.Plugins.Custodians.Kraken $DIST
