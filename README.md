# sliding-tiles
A 15 puzzle game clone I wrote to familiarise myself with Visual Basic syntax. Uses model-view-controller architecture.

To run the game, download all files, open the project in VB, set Sliding Puzzle as the StartUp project and press F5. The Sliding Puzzle project contains files necessary for the GUI game. The My Game project is an independant console application where you can use the commands "select", "moveUp", "moveDown", "moveLeft" and "moveRight" to test the logic. 

The objective of the game is to arrange the numbered tiles horizontally in the order of 1-15, with the blank tile being last. You can only move one tile at a time. You can only move a numbered tile onto the blank one. In the master branch version, you have to first click on a numbered tile to select it, and then onto the blank (or zero) tile to move it there. In the single-click version, you only have to click once on a numbered tile - the program will automatically move it to an adjacent empty tile (if one exists).

Let me know what you think!

Alex
