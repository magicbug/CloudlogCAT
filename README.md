# CloudlogCAT Version 2 (Development Copy)

## Intro

CloudlogCAT version two will be the main central hardware interface to Cloudlog, moving away from JSON API calls to endpoints and adding websocket functionality so that Cloudlog can access hardware directly for interaction. 

The other big selling point will be that this version will support unlimited radios and third party items, so you can have 4 radios and 4 rotators and CloudlogCAT will be fine with that.

# Programming Thoughts
* All hardware will have its own class but things like rigs will have similar function names across all types
* Decided to stick with Winform (I know could have used WPF but I think for this we will be ok

## Hardware Support
* Add Native Rig support
  * [x] Kenwood
  * [ ] ICOM
  * [ ] Yaesu
  * [ ] SunSDR TCL
  * [ ] Flex Radio
* - [ ] Add OmniRig Support just as an extra
* - [ ] SatPC32 DDE Interface (Removing the need for a second application)
* Other Hardware
  * [ ] Winkey
* Rotator Support
  * [ ] Yaesu GS232
  * [ ] Spid
  * [ ] PST Rotators API
* Amp Support
  * No idea on what sort of interfacing.
