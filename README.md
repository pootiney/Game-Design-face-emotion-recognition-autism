# Game-Design-face-emotion-recognition-autism

**This application is a game developed in Unity 2020.3.18f1 and it's goal is to train facial emotion recognition to Autistic Children.**

I'm using different softwares in developing this Game:

* Unity 2020.3.18f1
* Visual Studio 2017
* Adobe Photoshop 2021
* Adobe Illustrator 2020

## Installation:

* [Installation tutorial](https://www.aparat.com/v/aD7f4)  (This tutorial is in Persian)

* Run VPN

* Download Unity Hub

* Install Unity Hub

* Execute Unity Hub (tick the run unity hub and then finish installation)

* It wants a license, so exit Unity Hub (even end task in taskmanager to be sure you exit completely)

* Copy file app.asar (extract app.rar file) in this address "C:\Program Files\Unity Hub\resources"

* Run as administer Unity Hub

* Choose installs tab

* Click on add

* Choose desired version of unity 

* Next

* Choose desired modules of unity

* Choose android build support (includes SDK,NDKand JDK tools) to have andriod out put of your game

* When its completely installed exit the Unity Hub Completely

* Again Run as administer 

* Click on the 3 dots on top of the installed versionof unity 

* Choose patch pro

* Choose patch License

* Now the pro version of unity is activated On your laptop






## About the Game

**It has 4 Levels:**

1. [Gestalt Level](https://github.com/pootiney/Game-Design-face-emotion-recognition-autism/blob/main/README.md#gestalt-level)

2. [Emotion Training Level](https://github.com/pootiney/Game-Design-face-emotion-recognition-autism/blob/main/README.md#emotion-training-level)

3. [Emotion Expressing Level](https://github.com/pootiney/Game-Design-face-emotion-recognition-autism/blob/main/README.md#emotion-expressing-level)

4. [Emotion in the situation Level](https://github.com/pootiney/Game-Design-face-emotion-recognition-autism#emotion-in-the-situation-level)

> I'll explain each level in it's part completely

**But about generall features of software:**

when you run the software:

* You will see 4 Icons for 4 different levels that only first level is unlocked.
* When user finished first level the second level will be unlocked and respectively each higher level will be unlocked after finishing each lower level.
* After finishing each level that level will be locked. But after finishing all levels, entire levels will be locked.
* Software has a 20 minutes limit for using the game in each day.( Software will be closed after 20 minutes and will ask the player to click on Exit button and to continue tomorrow.)
* Software will continue the game from the start point of where the player had left.
* This 20 minutes limit can be divided to different time session which summation must be 20 mnutes.
* Software will notify to play each day.
> Questions arised in designing these features of the game.
>1. How I can choose an option by clicking on it?
>2. Application must have a realy small size, but how?
>3. How lock and Unlock the levels?
>4. How put the time limit?
>5. How can I have the time limit in seperate sessions in one day?
>6. How will the game continue from the start of the part which it was closed last time?
>7. How will the game notify to play every day?



### Gestalt Level:

This level has two parts.

1. Puzzle:

     User put different parts of an image next to each other and the final picture is a face.

2. Drag and Drop:

     User drag different parts of the face and drop them in correct part of face

for the first part I just tore apart the original image.

for the second part I seperate face components.

faces are in 3 different emotions happy, sad and angry.

**I'll upload code sources after their finished**
> Questions That arises:
>1. In puzzle how I determine that each piece of puzzle is located in correct place?
>2. In puzzle how I organize pieces to be chosen?
>3. How does the game cheer the player for each correct choice?
>4. How does the game collect the scores?
>5. In Drag and Drop how I organize pieces to be chosen?
>6. In Drag and Drop how I determine that each piece of puzzle is located in correct place?
>7. How does the game go to the next face when the previous one is solved?

### Emotion Training Level
**This level has 2 parts:**
1. Emotion rain part:
 
    This part has 3 categories, happy, sad and angry. When you choose each option, you'll face rain of emotional faces, and you must tap on emotions that you are in its category. If a face of not purposed emotion reach the ground it will be disapeared, but if it's  the purposed emotion it will remin on the ground and it will cause failure if it reaches a threshold. If the player tapped mistakably the wrong face it will cause score decrease and correct taps cause increase in scores. 
  
  >Questions that arises:
  >1. How do I make the rain?
  >2. How do I categorise the faces?
  >3. How does the game recognise that the faces have reached the ground?
  >4. How do the game recognise that I tapped the face?

2. Emotion recognition part:

      In this part different faces in happy, sad and angry emotions will be shown to the player randomly and they must tap one of three emojies in the buttom of the screen. If the answer where true it increases the score and if it's not it will decrease the score.
 > Questions arises:
 >1. How does the game choose the faces randomly?



### Emotion Expressing Level
**This level has 2 parts:**
1. Emotion Express Competetion:

In this part the player and a parent or an older sibling will play together. they both will look at the camera, the game will recognise their faces. Then the game will ask them to be sad or happy or angry by showing them the corresponding emoji, and will feedback them by tick or cross mark. If the player was true they will have an increase in they're scores. If the player was true but co-player wasn't it will say you are the winner, if they both are true it will say you both are winners and if the player is wrong it will tell oh so bad you loosed, Let's try again.
> Questions that arised:
>1. How the software will recognise the faces?
>2. How we will show the emojie exactly when we recognised the faces?
>3. How the software will recognise the emotion?
>4. How will we show the text or voice of applauding?
>5. How will we ask the player wants try again or not?

2. Express what You see:

In this part the player will see an neutral face in the center of the screen and will see an emojie in the bottom of the screen that shows an emotion. the player will express that emotion and if its true it will see the original picture's emotional state changes to what emojie says with a tick mark on top of it and success sound, and if it's not true it will show the correct emotion with a cross mark on top of it and failure sound!!It will askif you wanna continue or not? and if yes it will continue.

>Questions that arises:
>1. How it will play sounds?

 

### Emotion in the situation Level
In this part we explain different situations and then ask the player to express the emotion that is suitable for that situation. If the answer is true clap but if its not it will show a suitable face of the charecter to the player and when finished it will ask the player if they want to continue or not?
>Questions that arise:
>1. How to make an animated situation?


## Procedure

* First of all I started with designing level 1, part 2 (Drag and Drop):
   * I mde faces graphically ready, I've seperated the components of the faces. 
   * I wrote **"make_face.cs"** to check if the components are located in true place or not? and to change the face when it's finished.

    ''''C#
    
    ''''
   * I wrote **"draganddrop.cs "** to drag components.
