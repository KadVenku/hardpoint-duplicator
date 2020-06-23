# Hardpoint Duplicator

This tool can be used to quickly duplicate hardpoints for Empire at War.
It is provided "as-is" and is not actively supported by its creator.
If you want to pick it up and enhance it (because yes, it's hacky and ugly under the hood and needs some love) feel free to for and open a PR with your changes.

## Usage

HardPoint code to be duplicated n times can be provided as seen in the screenshot. Numbering should be replaced by a pattern that will be replaced by the catual hardpoint number. (See the red rectangles in the screenshot.)
If the hardpoint to duplicate is a turret, you can (but don't have to) check the "Hardpoint is a turret" option and auto-create rotation arc variants. You will have to provide the hardpoint base name though. In this example the base name would be `BMIC`

![](https://i.imgur.com/P1MJnNi.png)

The tool will output a txt file with the created variants inside of your `P:\ath\to\eaw.hardpointduplicator.exe\.hp-dump\timestamp-hp-dump.txt`
Those variants can be copied to wherever you need them.

## Licensing
The software is provided under the MIT License.
Refer to the LICENSE file for details.
