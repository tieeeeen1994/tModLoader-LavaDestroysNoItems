# Summary

This mod adds simple bonuses to the Angler Armor Set. These bonuses are the ability to add more fishing lines in Fishing Rods and the ability to have a chance to double or triple the catch.

Fishing Line number is configurable. Double catch chance is configurable. Triple catch chance is also configurable.

Triple catch chance will only be computed when the check for double catch chance is successful.

Each of the features can be disabled by setting their values to 0.

GitHub Repository: https://github.com/tieeeeen1994/tModLoader-AnglerArmorBonus

# Changelogs

v0.2
- Allow catches to only limit itself to the maximum allowable stack of the item.
- e.g. Zephyr Fish item will only still be 1 even if triple catch for it passed.
- The reason for this is that some items cannot be interacted with when they have a stack greater than 1 if their max stack is only 1.
- This feature is configurable.

v0.1
- Initial release.