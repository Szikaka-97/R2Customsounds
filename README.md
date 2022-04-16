# R2Customsounds
Plugin and API for adding custom sound events to Receiver 2

## How to install
1. Download the zip from *releases* section
2. Unpack it using a tool of your choice
3. Copy the R2CustomSounds folder into *\Receiver 2\BepInEx\plugins*
    - If you don't have BepInEx, you can download it from its [github page](https://github.com/BepInEx/BepInEx)

## Features
This plugin allows the creation and playback of custom sound events in Receiver 2 through a system similar to the one used for loading tapes, except using preloaded sound samples to reduce lag.

## API
To use the plugin's functionality in you own project, simply reference the dll and add a \[BepInDependedncy("R2CustomSounds")] attribute to your plugin main class

Made By SzikakA#3853
