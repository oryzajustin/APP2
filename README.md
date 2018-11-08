# Justin Koh 250837810

# Game Features
- Main Menu with START and EXIT options
- Player and AI engage in a game of "Dart Tag"
- Player walks with WASD and shoots with either left click or left-ctrl
- If the Player is NOT "it", can only run away
- AI runs away or tries to shoot the player dependin on if it is "it" or not
- AI uses NavMesh and NavMesh agent with way points to determine where to run from player
- Shooting is done VIA RayCast, where the AI will shoot when the player is in it's line of sight
- Indicator above the player that is "it"
- Game ends after 120 seconds
- Player can press "ESC" to be prompted to quit
- Player can QUIT at any time
- player and AI scores displayed
- End game menu
- implement a basic leaderboard system that stays between game sessions

# Issues
- AI sometimes gets stuck on collider edges
- collider edges are so precise that the AI can shoot over car hoods and between gaps in the obstacles