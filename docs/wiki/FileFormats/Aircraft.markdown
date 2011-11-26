# Aircraft

This guide will provide an introduction to the files and their formats used to store aircraft in YSFlight.

The original aircraft are stored in the aircraft/ folder. When YSFlight is loaded it will read the air*.lst (any file beginning with air and ending with .lst) from the aircraft/ folder, and load the files from this. 

## Overview of files

For each aircraft, there can be the following files (we will use the A6M5 ZERO as an example):

- Aircraft metadata and flight characteristics. Example **a6m5.dat**. See [DATFileStructure][DAT File Structure].
- Aircraft main 3D model, as seen by other players. Example **a6m5.dnm**. See [DNMFileStructure][DNM File Structure]].
- Aircraft collision model, a simple model used to determine whether a collision has occured with another object. Usually ends in **coll.srf**, example **a6m5_coll.srf**. See [SRFFileStructure][SRF File Structure].
- Aircraft cockpit model, shown when you are flying the aircraft. Usually ends in **cockpit.srf**, example **a6m5_cockpit.srf**. See [SRFFileStructure][SRF File Structure].
- Aircraft coarse model, a less detailed version shown when you are further away from the aircraft. Usually ends in **coarse.dnm**, example **a6m5_coarse.dnm**. See [DNMFileStructure][DNM File Structure].
- Aircraft instrument panel characteristics. Example **a6m5.ist**. See [ISTFileStructure][IST File Structure].

## Air*.list

For each of the aircraft there is a line in the air*.list file in the following format:

    path/to/aircraft.dat path/to/aircraft.dnm path/to/collision.srf path/to/cockpit.srf path/to/coarse.dnm

This is seperated by spaces, so files and paths cannot contain these.

Although the name of the file makes no difference of how the aircraft is loaded, I recommend you keep the original naming structure to make it easier for people to add custom aircraft.

The path to the files is from the root YSFlight directory, so it need not be in aircraft/, but again for ease of use I recommend you keep this structure. If you are making a custom pack you may want to create a subfolder in the aircraft folder.