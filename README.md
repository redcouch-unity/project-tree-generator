# Unity project tree generator
This script will generate basic folder structure for your Unity3D project, following the Red Couch Games conventions

## Getting started
Clone this repo inside your `Assets/Editor/` directory

## Usage
The Unity3D toolbar will be supplied with a new entry called `Tools`, under that new entry you can find the `Generate Project Tree` and the `Without .keep` and `With .keep`

Note: Git does not allow the storage of empty directory. The `.keep` file is a special file that tells git to keep the directory the file is in, even if it is empty

## Generated structure
```
Assets/Editor
Assets/Plugins
Assets/Resources
Assets/Resources/Prefabs
Assets/Scenes
Assets/Scripts
Assets/Scripts/Actors
Assets/Scripts/Behaviours
Assets/Scripts/Core
Assets/Scripts/Helpers
Assets/Scripts/Managers
Assets/Scripts/Menu
Assets/Scripts/Utils
Assets/Static
Assets/Static/Animations
Assets/Static/Effects
Assets/Static/Fonts
Assets/Static/Materials
Assets/Static/Models
Assets/Static/Models
Assets/Static/Music
Assets/Static/Prefabs
Assets/Static/Shaders
Assets/Static/Sounds
Assets/Static/Sprites
Assets/Static/Textures
Assets/Static/Videos
Assets/ThirdParty
```

## Credits
The original repository was created by [dkoprowski](https://github.com/dkoprowski) at [dkoprowski/UnityProjectTreeGenerator](https://github.com/dkoprowski/UnityProjectTreeGenerator) and modified by [maxpilotto](https://github.com/maxpilotto) for Red Couch Games