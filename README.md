# Unity Development for VR: A VEL guide

Welcome to the Virtual EmbodimentLab VR development guide! This guide is a great starting point to understanding how to use Unity and create immersive experiences for VR research. I have compiled a list of resources that will help you get started with Unity, C#, and Blender. If there is anything that you think should be added feel free to make a PR to add to this document.

Watch this video first:

[![Unity in 100 Seconds](https://i.ytimg.com/vi/iqlH4okiQqg/hq720.jpg?sqp=-oaymwEcCNAFEJQDSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLB5FZdmqXBFbssJztOEXyMSOizQjA)](https://www.youtube.com/watch?v=iqlH4okiQqg "Unity in 100 Seconds")

## Table of Contents

1. [Unity Tutorial](#tutorial-sections)
    <!-- 1. [Part 1: Basic Movement](#programming-basics-for-unity)
    1. [Part 2: Better Movement](#unity-for-vr-development)
    1. [Part 3: Advanced Movement](#3d-modeling-in-blender)
    1. [Part 4: Plugins](#blender-to-unity-workflow)
    1. [Part 5: TODO](#blender-to-unity-workflow)
    1. [Part 6: Networking](#additional-resources)
    1. [Part 7: Triggers](#additional-resources)
    1. [Part 8: IK Avatars](#additional-resources)
    1. [Part 9: Animation](#additional-resources) -->
1. [Introduction to Unity](#introduction-to-unity)
    1. [Programming Basics for Unity](#programming-basics-for-unity)
    1. [Unity for VR Development](#unity-for-vr-development)
    1. [3D Modeling in Blender](#3d-modeling-in-blender)
    1. [Blender to Unity Workflow](#blender-to-unity-workflow)
    1. [Additional Resources](#additional-resources)

## Unity Tutorial

Welcome to the Unity Tutorial guide. This tutorial is meticulously crafted to guide you through various facets of Unity development, particularly tailored for a research setting. Navigate through the sections below to explore the depth of topics covered.

## Tutorial Sections

This Unity tutorial, tailored for research labs, delves into various aspects of Unity development. It's structured into distinct parts, each focusing on a specific topic. Each section provides hands-on scripts and resources to help you learn and apply the concepts. The tutorial is designed to be followed in sequence, but you can jump to a specific section if you're already familiar with the basics.

[Link to the full tutorial README](./Assets/Tutorial/README.md)

- [Part 1: Basic Movement](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%201%20Basic%20Movement)
- [Part 2: Better Movement](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%202%20Better%20Movement)
- [Part 3: Advanced Movement](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%203%20Advanced%20Movement)
- [Part 4: Plugins and Complexity](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%204%20Plugins%20and%20complexity)
- [Part 6: Networking](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%206%20Networking)
- [Part 7: Triggers](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%207%20Triggers)
- [Part 8: IK Avatars](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%208%20IK%20Avatars)
- [Part 9: Animation Blending](https://github.com/virtual-embodiment-lab/unity-tutorial/tree/main/Assets/Tutorial/Part%209%20Animation%20Blending)

## Introduction to Unity

Unity has emerged as a predominant game development platform in the realm of virtual reality (VR) research. Its versatility, combined with an intuitive interface and extensive support for VR hardware, has made it an attractive choice for researchers. The platform's adaptability allows for the creation of diverse VR environments tailored to specific study objectives. Furthermore, Unity's active community and comprehensive documentation provide invaluable resources, ensuring that researchers can overcome challenges and continually innovate in their VR experiments.

### Unity Hub

Unity Hub is a standalone application developed by Unity Technologies designed to streamline the management of multiple Unity projects, versions, and modules. It's a centralized platform for Unity developers to manage various aspects of Unity development.

#### Key Features:

- **Multiple Unity Versions**: Unity Hub allows you to install and switch between different versions of Unity. This is especially useful when working on multiple projects that might require different Unity versions.
  
- **Project Management**: Easily create new projects or open existing ones. Unity Hub provides a clear overview of all your Unity projects in one place.

- **Module Installation**: When installing a new version of Unity, Unity Hub lets you choose which components or modules (e.g., Android Build Support, WebGL Build Support) you want to install alongside the main editor.

- **Templates**: Unity Hub offers a variety of project templates, such as 2D, 3D, VR, and more, to kickstart your development.

- **License Management**: You can activate, return, or manage your Unity licenses directly from the Hub.

- **Tutorials and Learning**: Unity Hub provides links to official Unity tutorials, documentation, and other learning resources, making it easier for developers to access educational content.

#### Getting Started with Unity Hub:

1. **Installation**: Download and install Unity Hub from the [official Unity website](https://unity3d.com/get-unity/download).
   
2. **Sign In**: After installation, open Unity Hub and sign in with your Unity ID. If you don't have one, you can create it for free.

3. **Setting Up**: Once signed in, you can start adding Unity versions, creating or opening projects, and customizing your Hub settings.

#### Tips:

- Always ensure that your Unity Hub is updated to the latest version to benefit from the latest features and improvements.
  
- If you're collaborating with a team, it's a good practice to ensure everyone is using the same Unity version for consistency. Unity Hub makes managing this easier.

### What is Unity?

Unity is a cross-platform game engine developed by Unity Technologies. It's used to develop video games for web plugins, desktop platforms, consoles, and mobile devices.

### Getting Started with Unity

- [Getting started with Unity Tutorial](https://unity.com/learn/get-started)
- [Unity Essentials](https://learn.unity.com/pathway/unity-essentials)
- [The Unity Tutorial For Complete Beginners](https://www.youtube.com/watch?v=XtQMytORBmM)
- [How to make a Video Game - Getting Started](https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6)
- [Build Your First 3D Game in Unity | Unity Beginner Tutorial](https://www.youtube.com/watch?v=n0GQL5JgJcY&list=PLrnPJCHvNZuB5ATsJZLKX3AW4V9XaIV9b)
- [#1 | LEARN UNITY AS AN ABSOLUTE BEGINNER! 🎮 | Getting Started With Unity | Learn Unity For Free](https://www.youtube.com/watch?v=xw6DR7uuNz0)

### Download Unity

You can [download Unity here](https://unity.com/download).

## Programming Basics for Unity

Before diving into VR, it's essential to understand the basics of programming in Unity.

- **Unity Scripting API**  
  Familiarize yourself with the [Unity Scripting API](https://docs.unity3d.com/ScriptReference/).

- **C# Basics for Unity**  
  - Learn the basics of C# in Unity with this entire playlist [Beginning C# with Unity (2023 Edition) - Getting Started](https://www.youtube.com/watch?v=lgUIx75fJ_E&list=PLFgjYYTq6xyhtVK6VzLiFe3pmBu-XSNlX)
  - [Watch this C# tutorial series on YouTube](https://www.youtube.com/watch?v=N775KsWQVkw&t=1s)

## Unity for VR Development

Unity offers robust tools and features to make VR development seamless.

- **Setting up Unity for VR**  
  [Unity VR Docs](https://docs.unity3d.com/Manual/VROverview.html)
  [Introduction to VR in Unity - PART 1 : VR SETUP](https://www.youtube.com/watch?v=gGYtahQjmWQ)

- **VR Interaction Fundamentals**  
  Learn the basics of VR in Unity with this [Create with VR](https://learn.unity.com/course/create-with-vr) and this [Easy Unity VR Tutorial for Beginners](https://xrbootcamp.com/unity-vr-tutorial-for-beginners/).
  - [How to Make a VR Game in Unity - PART 1](https://www.youtube.com/watch?v=HhtTtvBF5bI&t=8s).
  
## 3D Modeling in Blender

Blender is a powerful free tool for creating 3D models. It's widely used in conjunction with Unity for game and VR development.

- **Getting Started with Blender**  
  If you're new to Blender, [watch this beginner's guide on YouTube](https://www.youtube.com/placeholder_link).

- **Modeling Techniques**  
  - [Start Modelling In Blender For Unity - Part 1 - Modelling](https://www.youtube.com/watch?v=obuh4RCVNCM).
  - [Blender Beginner Tutorial - Part 1](https://www.youtube.com/watch?v=nIoXOplUvAw&t=12s).
  - [GAME ASSET BEGINNER TUTORIAL - Blender to Unity (Introduction)](https://www.youtube.com/watch?v=KFEb51rinwI).

## Blender to Unity Workflow

Integrating Blender and Unity can be a breeze if you know the right steps.

- **Exporting Models from Blender to Unity**  
  [How to Import BLENDER FILES into Unity - Step by Step Tutorial](https://www.youtube.com/watch?v=sZ8lvoUtGYg&pp=ygUZYmxlbmRlciB0byB1bml0eSB0dXRvcmlhbA%3D%3D).

- **Optimizing Blender Models for Unity**  
  Ensure your 3D models are optimized for game performance with [this guide](https://www.youtube.com/watch?v=yjZLAtgdp-c).

## Additional Resources

- [Unity Documentation](https://docs.unity3d.com/Manual/index.html)
- [Blender Documentation](https://docs.blender.org/manual/en/latest/)
- [Unity VR Samples](https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-vr-samples-51519)

---

**Contributors**: [Jonathan Segal](https://github.com/Jonathannsegal)
