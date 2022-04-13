# Genshin Impact Movement System

An attempt on replicating 3 *(Moving, Gliding, Swimming)* Genshin Impact Movement Systems.

![Overview](https://imgur.com/wrcRkc6.png)

### Engine

[![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/)

### Available On

[![YouTube](https://img.shields.io/badge/Youtube\_(Tutorial\_Series)-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)](https://www.youtube.com/watch?v=-HCv142Uqhk&list=PL0yxB6cCkoWKuPoh_9dSvdItQENVx7YTW) [![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Wafflus/to-delete/blob/master/Testing/README.md)

### Used Assets

Provided Animations were downloaded from [Mixamo](https://www.mixamo.com/).

Map Materials were downloaded from [Kenneys Assets](https://www.kenney.nl/assets/prototype-textures).

### Tips

- If you intend to Swap Animations, make sure you copy their **Animation Events**, otherwise some transitions won't work.
- There's no particular reason why I made the Model "Generic" besides me not understanding enough about Animations.
- There are no Control Schemes in the Input Actions, so Input only works for Keyboard & Mouse.
- Because I use the ``[field: SerializeField]`` attribute, ``Unity 2020+`` is required. ``2020.3 LTS`` was used for this project.
- If you want different settings for a **smaller** or **taller** character, you can create a new `Player Scriptable Object` and set the desired settings.
- There's a ``Resizable Capsule Collider`` Component for you to add to any Game Object you want to resize your collider from the bottom only to be able to use the `Floating Capsule` technique. It should throw an error once when you first add it as a Component due to the `OnValidate` method likely being called before Unity serializes the data classes, but it should work fine. You can always initialize the ``[Serializable]`` classes in the `Initialize` method if you don't want that error showing.
- 2 Layers are added from the Layer number 22 to 23, in hopes that there would be no problem in importing this System to your own project. All scripts have a base namespace and folder as well, so there should be no name conflicts.
- A camera cursor script was added as an example on how you can enable or disable it. It isn't working like in the game, it's just there for you to have an idea how to get it enabled or disabled.
- Different Animations can make the movement look better or worse.
- I'm an amateur game developer, so do not expect the code to be the most elegant looking piece of beautiful meat out there.
- If there's a Bug, you saw nothing.

# Table of Contents

<details>
  <summary>Unveil me!</summary>

- [Genshin Impact Movement System](#genshin-impact-movement-system)
    - [Engine](#engine)
    - [Available On](#available-on)
    - [Used Assets](#used-assets)
    - [Tips](#tips)
- [Tutorial Series](#tutorial-series)
  - [Series Contents](#series-contents)
- [Pro Builder](#pro-builder)
- [New Input System](#new-input-system)
- [Systems](#systems)
  - [Movement System](#movement-system)
    - [Cinemachine](#cinemachine)
    - [States & State Machines](#states--state-machines)
    - [Floating Capsule](#floating-capsule)
    - [Physics-Based Movement](#physics-based-movement)
      - [Player Movement](#player-movement)
      - [Player Rotation](#player-rotation)
      - [Player Dash](#player-dash)
      - [Player Jump](#player-jump)
      - [Player Fall](#player-fall)
      - [Player Landing](#player-landing)
  - [Animations](#animations)
  - [Gliding System](#gliding-system)
  - [Swimming System](#swimming-system)
- [License](#license)
- [Version](#version)
- [Contributing](#contributing)
- [Notes](#notes)
</details>

# Tutorial Series

Released code is only up to date to my last released [Tutorial Series](https://www.youtube.com/watch?v=-HCv142Uqhk&list=PL0yxB6cCkoWKuPoh_9dSvdItQENVx7YTW) video.

To get an idea on what the [Tutorial Series](https://www.youtube.com/watch?v=-HCv142Uqhk&list=PL0yxB6cCkoWKuPoh_9dSvdItQENVx7YTW) will end up providing, please refer to [This Video](https://www.youtube.com/watch?v=eIvHy4TF9kc).

## Series Contents

The main goal of the Series is to teach game developers *(mostly beginners)* on how can they achieve something similar to Genshin Impact Movement System.

Here's the list of techniques used to make this System possible:

- Pro Builder

  > A Small Test Map was created for this Project.

- New Input System

  > The Old Input System was disabled for this Project.
  
  > Version 1.3.0

- Cinemachine

  > A Virtual Camera was used to achieve the same or close to the same result as Genshin Camera.
  
  > Version 2.8.4*
 
- State Machines

  > Hierarchy State Machines were used at their simplest implementation (State Inheritance).
 
- Floating Capsule

  > Allows Resizing the Capsule Collider without the Player falling due to Gravity.

  > Makes it possible to climb steps and slopes.

- Physics-Based Movement

  > A Rigidbody was used for all the Player Movement.
  
  > No Built-In Character Controller was used.

- Animations

  > Reusable Sub-State Machines were used for the Animations.
  
  > No Blend Trees were used.

*As of this version, there's a bug that doesn't allow disabling the **Cinemachine Input Provider** actions, which could be used for disabling the Camera Rotation or the Camera Zoom. [It should be fixed in future versions](https://github.com/Unity-Technologies/com.unity.cinemachine/commit/512f0c033619dcf86d9afd83af35198bc003cac1).

# Pro Builder

A Small Test Map was created in hopes of being able to test all features this System will provide.

Uses [Kenneys Prototype Textures](https://www.kenney.nl/assets/prototype-textures) as the Map Materials.

![Map](https://imgur.com/zkI9Uxx.png)

# New Input System

The use of Unity New Input System allows the addition of callbacks whenever a key was `pressed`, `changed` or `unpressed`.

These translate to the actions of `started`, `performed` and `canceled`.

Features like only considering the key being pressed **after an amount of time has passed** is also easily achieved by using an **Interaction**.

The Camera also uses the **New Input System**.

The Project does not provide a **Control Scheme** and only provides you with **Keyboard Inputs**.

https://user-images.githubusercontent.com/71723988/163193573-92364ecc-90aa-4197-a0b4-ccf9c7a2550e.mp4

# Systems

The plan is to develop and release 3 Genshin Impact Movement Systems.

[![Generic badge](https://img.shields.io/badge/Status-RELEASED-brightgreen.svg)](https://shields.io/) Means the System has been **fully released** on both **Youtube** and **Github**.

[![Generic badge](https://img.shields.io/badge/Status-DEVELOPED-green.svg)](https://shields.io/) Means the System has been **fully developed** but is **awaiting release** on both **Youtube** and / or **Github** or **awaiting for another System release**.

[![Generic badge](https://img.shields.io/badge/Status-WIP-yellow.svg)](https://shields.io/) Means the System is **still in Development** or **requires something to be Fixed** before it can be **released**.

## Movement System

[![Generic badge](https://img.shields.io/badge/Status-RELEASED-brightgreen.svg)](https://shields.io/)

### Cinemachine

The Player Camera imitates Genshin Impact Camera using Unity Cinemachine Package.

This is **very likely** what Genshin uses as well.

All 3 Systems have **different settings** for the Camera but it **mostly** works the same way.

The Camera offers an **Orbital Rotation** around the Player.

https://user-images.githubusercontent.com/71723988/163193893-925b1bda-f136-4e5d-b08a-72e8581fed69.mp4

[Click here for longer video (47MB)](https://imgur.com/0VpzZbu.png)

We can **Zoom In** and **Zoom Out** using the **Mouse Scroll Wheel**.

https://user-images.githubusercontent.com/71723988/163194107-40c4c560-6187-459d-8c03-65ff51b32611.mp4

[Click here for longer video (83.6MB)](https://imgur.com/9dAcWpq.png)

It also offers different **Rotations** at **different angles** or **movement directions**.

For example, moving the Player to the **sides** slowly **rotates the Camera**, which in itself **rotates the Player**, as the Player Rotation **is relative to the Camera**.

https://user-images.githubusercontent.com/71723988/163194247-a0c4165b-2689-452c-ad3e-4bc61bdfe19c.mp4

[Click here for longer video (31.7MB)](https://imgur.com/G95rVII.png)

When looking from the **Top** or **Bottom**, it also **rotates faster**, which makes the Player move in a **small circular motion** *(much like in Genshin)*.

https://user-images.githubusercontent.com/71723988/163194317-fe6dc049-c7b6-42b7-9aa2-c9e940b75cb5.mp4

[Click here for longer video (120MB)](https://imgur.com/2Zk6M0k.png)

There are several possible **rotation outcomes**, all of which I speak of in my [Tutorial Series Video about Camera Recentering](https://www.youtube.com/watch?v=PR9w3g2a-70).

### States & State Machines

The main logic of the Player Movement follows the State Machines Pattern.

I've decided to **cache** the existing States instead of **instantiating** new ones.

Therefore, changing to another State can be done through a similar code line: `stateMachine.ChangeState(stateMachine.IdlingState)`.

https://user-images.githubusercontent.com/71723988/163194359-712e2003-7168-4b72-a835-f5efa6839bb9.mp4

[Click here for longer video (42MB)](https://imgur.com/qoCx2py.png)

### Floating Capsule

To prevent the Player from getting stuck on **steps** as well as to prevent the Player from jumping on **slopes**, a **force** is constantly added to the Player to keep it afloat.

A **resizable capsule collider** feature is provided, which is considered the same as the **maximum climbable step height**.

The size is only removed from the **bottom**.

https://user-images.githubusercontent.com/71723988/163194385-0fd32207-47b7-4c4b-ab67-350b7da342ec.mp4

To prevent the Player from falling due to Gravity when its collider is resized, a **Ray** is cast downwards and a *(positive or negative)* **force** is added to the Player depending on the **distance** from the **collider center** to the **ground**.

This allows the Player to keep itself at a constant height both when moving on **slopes** or when trying to climb **steps**.

https://user-images.githubusercontent.com/71723988/163194421-304d9aa2-2eee-40a9-bbe5-5854f405761a.mp4

[Click here for longer video (55.2MB)](https://imgur.com/qXv7O2H.png)

The idea was taken [From This Video](https://www.youtube.com/watch?v=qdskE8PJy6Q).

### Physics-Based Movement

A **Rigidbody** is used for the Character Movement, meaning that it moves using **built-in** Physics.

#### Player Movement

The Ground Movement offers Walking, Running, Dashing, Sprinting, Landing and Stopping States as well as a way to swap between Walking and Running at the press of a Button.

There's also Jumping and Falling.

https://user-images.githubusercontent.com/71723988/163195407-64ca4ae0-43ca-49cd-8ec4-72ae23633601.mp4

[Click here for longer video (95.5MB)](https://imgur.com/pc3wILB.png)

The Player also moves slower depending on the Slope / Ground Angle *(An Animation Curve is used to set the Angles and Speeds)*.

https://user-images.githubusercontent.com/71723988/163194680-f1ca5f87-7c7d-47ff-bd25-0128ed543065.mp4

[Click here for longer video (41.2MB)](https://imgur.com/ecd7P6Q.png)

The System also offers the transition between Sprinting to Running and Walking when the Sprint key wasn't held long enough to keep performing it.

https://user-images.githubusercontent.com/71723988/163194715-b6e56110-c97f-4617-b9fa-b4552c967443.mp4

#### Player Rotation

The Player rotates **relative** to the **Camera** and the **Movement Input**.

https://user-images.githubusercontent.com/71723988/163194471-424046dc-4a1c-4d39-8428-9f6d8697b4a2.mp4

[Click here for longer video (27.3MB)](https://imgur.com/VU9tbxJ.png)

Much like in Genshin, it offers an **Automatic Rotation** in certain situations.

For example, **fast pressing** *(pressing and releasing right away)* a **movement key** will keep rotating the Player until it's looking towards the desired **movement direction**.

https://user-images.githubusercontent.com/71723988/163194496-f0f58093-ec79-4e7f-a6f9-eb6ac98d1a0b.mp4

[Click here for longer video (39.1MB)](https://imgur.com/NKVgeCd.png)

#### Player Dash

The Player can dash up to 2 times *(updatable)* in less than 1 second *(updatable)*.

If the Player dashes too fast, it will enter a Cooldown *(updatable)* and the Player will only be able to dash again after that cooldown ends.

https://user-images.githubusercontent.com/71723988/163194734-88f24d93-c15e-4174-884f-c12545caa018.mp4

[Click here for longer video (50.7MB)](https://imgur.com/Z3j88vR.png)

#### Player Jump

The Player Jump offers a few different possibilities on where to Jump much like in Genshin.

If there's a **Movement Input Key** being pressed, the **Player** will Jump towards the direction of that **Movement Key**.

https://user-images.githubusercontent.com/71723988/163194774-37b89a3d-1008-447d-a8eb-78444a98f898.mp4

[Click here for longer video (37.2MB)](https://imgur.com/lpd2ZJD.png)

If there's no **Movement Input Key** being pressed, the **Player** will Jump towards the direction it's **facing**.

https://user-images.githubusercontent.com/71723988/163194805-86edbe68-88f3-4b6d-8bd5-8a94f9e3faa4.mp4

[Click here for longer video (71.5MB)](https://imgur.com/uHoc9Of.png)

Furthermore, its force depends on the current Player State as well as the Slope / Ground Angle *(An Animation Curve is used to set the Angles and Forces)*.

This is to ensure that the **Player does not slide** on Slopes from having too much of an **Horizontal Velocity**.

https://user-images.githubusercontent.com/71723988/163194836-a8f04699-cc1d-409e-be04-6668b46344a2.mp4

[Click here for longer video (79MB)](https://imgur.com/qXA0nEu.png)

#### Player Fall

When the **Player** leaves the **Ground**, it will start **Falling**.

https://user-images.githubusercontent.com/71723988/163194885-4edc148d-0bf8-408b-a184-19b15d8d7330.mp4

The **Jump** also transitions to **Falling** when it reaches its **top vertical positive velocity** *(exactly when the velocity starts becoming negative)*.

https://user-images.githubusercontent.com/71723988/163194929-8a22cd76-9387-4fbe-84a6-b9202c71f8bb.mp4

A velocity limit is set to make sure it collides with shallow ground colliders correctly.

https://user-images.githubusercontent.com/71723988/163194959-a2678393-4c23-4c8d-8d5e-834b62ed6f3a.mp4

#### Player Landing

When the **Player** collides with the **Ground** coming from an **Airborne State**, it can enter a **Landing State**.

The common **Landing State** between all the **Airborne States** is the **Light Landing State**, which happens when the **Player** falls from a small height.

https://user-images.githubusercontent.com/71723988/163194989-ad110106-573e-4103-b024-60d573fd56cd.mp4

[Click here for longer video (41.5MB)](https://imgur.com/C0FF5CI.png)

When coming from the **Falling State**, 2 new **Landing States** are added: **Hard Landing** and **Rolling**.

**Hard Landing** happens when the **Player** falls from an **high height** and has no **Movement Input Key** being pressed at the moment of contact.

https://user-images.githubusercontent.com/71723988/163195012-df532031-a5ab-49a0-b65b-ebfb1170a11d.mp4

**Rolling** happens when the **Player** falls from an **high height** and has a **Movement Input Key** being pressed at the moment of contact.

https://user-images.githubusercontent.com/71723988/163195031-6aff52aa-9971-4fe2-abe7-ebe45ae09a21.mp4

## Animations

Animations are added through an Animator Controller using **Reusable Sub-State Machines** *(No Blend Trees are used)*.

https://user-images.githubusercontent.com/71723988/163195047-36ab2a11-cc99-42e5-8358-40ffd697f80f.mp4

There are Animations for every State.

## Gliding System

[![Generic badge](https://img.shields.io/badge/Status-WIP-yellow.svg)](https://shields.io/)

- [X] State Machine & States *(Transitions Included)*
- [X] Glides
- [X] Different Camera Settings
- [X] Player Animations *(Glide Start Animation Included)*
- [ ] Player Tilt *(Needs to be fixed)*

## Swimming System

[![Generic badge](https://img.shields.io/badge/Status-WIP-yellow.svg)](https://shields.io/)

- [X] State Machine & States *(Transitions Included)*
- [X] Swims *(Fast Swim Included)*
- [X] Dives
- [X] Floats
- [X] Submerges
- [X] Different Camera Orbit
- [X] Different Camera Settings
- [X] Player Animations
- [ ] Can go back to the Ground *(Needs to be fixed in a certain Situation)*
- [ ] Movement *(Needs to be reviewed to make sure it's working as intended)*
- [ ] Rotation *(Needs to be fixed in a certain Situation)*

# License

[![License](https://img.shields.io/badge/LICENSE-MIT-ff1709?style=for-the-badge&logoColor=white&color=orange&labelColor=gray)](LICENSE.md)

**Mixamo Animations** & **Kenney's Prototype Textures** are not considered in my License and are provided just so you can test the System.

Their licenses still apply.

# Version

![License](https://img.shields.io/badge/VERSION-1.0.0-ff1709?style=for-the-badge&logoColor=white&color=blue&labelColor=gray)

# Contributing

This Movement System will only be updated as I release more Videos for my Tutorial Series.

If you want to support me, consider **subscribing to my Youtube Channel** and / or **following me on Twitter**, both would help me out a ton and be appreciated.

[![YouTube](https://img.shields.io/badge/Subscribe-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)](https://www.youtube.com/c/IndieWafflus?sub_confirmation=1) [![Twitter](https://img.shields.io/badge/Follow-%231DA1F2.svg?style=for-the-badge&logo=Twitter&logoColor=white)](https://twitter.com/intent/follow?original_referer=https%3A%2F%2Fpublish.twitter.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Efollow%7Ctwgr%5EIndieWafflus&screen_name=IndieWafflus)

# Notes

Animations were downloaded from https://www.mixamo.com.

I use [Kenney's Prototype Textures](https://www.kenney.nl/assets/prototype-textures) for the Included Map.

As of the moment I released this repository, [I'm on a break](https://youtu.be/FwHlWprug9M).

This means that the System won't be updated soon and it might take a while for the rest of the Systems to be released.