#!/bin/bash
#/sudo apt install nuget
sudo apt install libcanberra-gtk-module
#sudo apt-get install nunit-console
nuget restore Enigma.sln
#msbuild /p:Configuraton=Release Enigma.sln
#cd Enigma/bin/Release
mono Enigma.exe