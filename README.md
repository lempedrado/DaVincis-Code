# DaVinci's Code

## Overview

DaVinci's Code is a board game where each player has a numbered code that the other players have to try to guess before their own code is revealed.

## Pieces

- A set of black tiles
- A set of white tiles

The tiles are numbered starting from 0. The max value of the tiles varies depending on the difficulty and/or the number of players.

## Tile Order

- All tiles are numbered.
- Tiles are placed in increasing order from left to right.
- If a player has two tiles with the same value, the black tile is placed further to the left.

- If wildcards are enabled, a black and white tile labeled `-` is added.
- Wildcard tiles have no specific value and can be placed anywhere in a player's code.

## Gameplay

- The tiles are shuffled and 4 random tiles are distributed to each player to start and placed in order.
- A player's turn starts by drawing a new tile and placing it appropriately in their code.
- The player then chooses another player's tile and guesses it's value.
    - If the player guesses correctly, they can choose to pass their turn or continue to guess tiles from any player.
    - If the player guesses incorrectly, they drop the tile they just drew, revealing it's value to all players.
- Repeat until there is one person left whose code has not been fully revealed.
- If players run out of tiles to draw, continue taking turns guessing other player's tiles and revealing a tile if guessed incorrectly.
