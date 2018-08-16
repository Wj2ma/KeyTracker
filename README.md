# KeyTracker
Tracks key presses for FFR, StepMania, or any other 4 key game. Only supports Windows operating system.

# SETUP

Open the config.txt file in the KeyTracker folder, and fill in the desired settings.

For setting the key mapping, all alphanumerical characters are accepted, as well as the numpad and arrow keys. For numpad keys, please enter NUM# for the desired numpad number (eg. NUM1 for numpad 1). For arrow keys, enter one of LEFT, DOWN, UP, or RIGHT.

**\*\*\*IMPORTANT\*\*\***

If the app does not start after modifying the config file, you may have made a mistake in setting it up. Please look at the example config file below as a reference. Be cautious about not missing a quote or a comma.

## Settings

Left - the key you press for hitting the left arrow

Down - the key you press for hitting the down arrow

Up - the key you press for hitting the up arrow

Right - the key you press for hitting the right arrow

Overlay - set to true if you want the window to appear on top of all your other windows. Set it to false otherwise.

KpsColours - set to true if you want the kps label to change colours when it reaches certain thresholds. Set it to false otherwise.

Tier0 - when KpsColours is true, kps values up to and including this number will have the tier 0 colour.

Tier1 - when KpsColours is true, kps values in between Tier0 and this number will have the tier 1 colour.

Tier2 - when KpsColours is true, kps values in between Tier1 and this number will have the tier 2 colour.

Tier3 - when KpsColours is true, kps values in between Tier2 and this number will have the tier 3 colour.

Tier4 - when KpsColours is true, kps values in between Tier3 and this number will have the tier 4 colour. Everything above will have the tier 5 colour.

## Example

```
{
	"Left": "a",
	"Down": "s",
	"Up": ";",
	"Right": "'",
	"Overlay": true,
	"KpsColours": true,
	"Tier0": 9,
	"Tier1": 12,
	"Tier2": 15,
	"Tier3": 18,
	"Tier4": 20
}
```

# USAGE

Run KeyTracker.exe to start the program.

To start and stop the tracker, press ALT + R. The red bar should turn green, and the timer should start counting up when you start tracking.

## What do these stats mean?

**KPS** means how many keys you pressed in the last second, while **Peak** means the highest KPS you've achieved during the current session. The rest should be straightforward.
