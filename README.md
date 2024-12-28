# **Space Adventure**

Evan Zhang

Space Adventure is a Space-Themed Game where the player wanders around exploring a spaceship. The goal is to ultimately figure out how to entire the cockpit and move the spaceship to a mysterious green portal.

I made this game to learn about VR/AR development in Unity.  I watched tutorials by Valem Tutorials on Youtube which was super helpful.  The majority of the assets here come from Valem.

### **Sped Up Video Walkthrough (Click the image):**

[![Game Walkthrough](https://img.youtube.com/vi/CxUsBicEldU/0.jpg)](https://www.youtube.com/watch?v=CxUsBicEldU&ab_channel=EvanZhang "Video Walkthrough")

## Setup Instructions for Running Locally

### 1. Prerequisites
Have the following installed:
- **Unity**: Version `2023.1.5f1`
- **Git**: [Download Git](https://git-scm.com/downloads)

### 2. Clone the Repository
1. Open a terminal or command prompt.
2. Run the following command:
   ```bash
   git clone https://github.com/theflabbypotato/Space_Adventure

The `Packages` and `Project Settings` should work and have all the settings that I used to make my project

Or to just play the game, if you are on Mac, download the `/Builds/Space Adventure (Mac).app` and double click to run.  If you are on Windows, download the `/Builds/Space Adventure (Windows).app` and double click to run

# **Parts of the Project**

- Built the environment using space prefabs
- Lighting
- Grabbing script for objects and interactions
- Movement and teleportation on right hand
- Button and door interaction
- Ladder
- Wheel and lever for "moving" the spaceship
- Game story with narration
- Menu and UI
- In-game audio
- Optimizing build (like baking)

## **Files**

- `/Assets` All the assets with like prefabs, materials, the scenes, helpful folders etc.
- `/Builds` The builds to launch the game, one for Mac and one for Windows
- `/Packages` Relevant packages
- `/Project Settings` Settings information for things like graphics, audio, timeline, etc.

# **Learning Journey**

### **What inspired you to create this project**

I've always wanted to give AR/VR design a shot and I thought that this would be a great opportunity to give it a shot.

### **What potential impact do you believe it could have on its intended users or the broader community**

While Space Adventure is just a simple story, I hope that it might be bring at least a little joy to anyone who gets to experience it.  Maybe someone else will be inspired to delve in AR/VR and make their own game.

### **What new technology you learned**

Honestly, this entire process was new to me regarding Unity and AR/VR technology.  I've made a few games before but nothing like this one.  I think using this new technology really showed me the difference of working in a 3D virtual world.  I learned a lot about how to work with Unity and create a lot of basic functions and interactions that were a lot more intricate than what I expected. 

### **Why you chose the new technology**

Unity does an amazing job of abstracting VR/AR game design as while you do have to write some scripts for custom tasks, it creates a user friendly environment that doesn't require creators to code many of the complicated background frameworks (like the XR Interaction Toolkit). 

### **Challenges you faced, and what you learned from the experience**

Since everything was new to me, I faced a lot of challenges in trying to make everything work.  I had to figure out having to get around not having a VR headset, I had to fix bugs in my environment and code, I had to learn how navigate around the Unity interface, and much more.  I think I learned to be persistent when working on challenges and (crucially) to take breaks when needed.  Sometimes, what worked best was just stepping away from my work and coming back later with a clear mind to try again.

## **Note About XR Device Simulation**

Unfortunately I don't have any kind of VR headset or hardware of my own so I had to implement an XR device simulator to navigate my VR environment.

Here is a link to some documentation on how to use it (Look at the Sample Control part):

[XR Simulator Walkthrough](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.0/manual/xr-device-simulator.html)

## **Bugs**

This obviously isn't ideal but there were a few bugs with my game

1. Sometimes the game's framerate is lower but if you quit and reopen it is fixes it (dunno why this happen for some reason)
2. (This might just be a problem with the XR Device Simulator) When ascending near the ladder part, you might get teleported above the spaceship but this is strange since there aren't any rigid bodies blocking that area