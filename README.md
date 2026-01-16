[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
The draw-out planning I did when observing the game turns out to be very comprehensive. Before even looking at the rubric, I swiftly discovered the key features of the penguins, including no-double-jumping (which means the isGrounded variable and corresponding method for detection is essential; it is done by checking collision with the object tagged "ground"), and how the penguin doesn't actually have horizontal movement (thus only jumping -- upward impulse on the rigidbody -- is applied in my code). Respectively, the coins are spawned and move leftward in a random interval, which matches exactly with how I've wrote the GameController script and set up for coin prefabs with leftward scripted movement (and self-destroy after out of scene). I was originally hesitating about the necessity of a "ground", but I still wrote it out and actually implemented it in my game because it feels more intuitively correct to have an actual contactable ground, rather than restricting the penguin's falling to a specific y-value or something. Overall, the construction of the game went smooth! 


## Activity 1: MG2 Breakdown
![IMG_2841](https://github.com/user-attachments/assets/acfa7e29-acb1-4381-b2d9-4b4c00131259)


## Activity 2: MG2 Progress
[Commits Made](https://github.com/UCI-GDIM32-W25/mg2-JeremyC140/commits/main/)
I finished the assets setup, the jumping of penguin (and isGrounded check), the UI with TMP_text (but not yet the update part), collision check in the penguin script, and attempt on the coin moving script as well as the game controller. 
TO-DO:
- Fix the bugs that coins are not instantiate in the right posision
- Fix coins not moving
- Assign enough variables to update the text 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
