using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GameEngine
{
    public class Animation // Individual animation, many of these usually make up an ANimationSet
    {
        public string name;
        public List<int> animationOrder = new List<int>();
        public int speed;

        public Animation()
        {

        }

        public Animation(string inputName, int inputSpeed, List<int> inputAnimationOrder)
        {
            name = inputName;
            speed = inputSpeed;
            animationOrder = inputAnimationOrder;
        }
    }

    public class AnimationSet
    {
        public int width; //Width of each frame
        public int height; //Hight of each frame
        public int gridX; //How many frames are in the x direction
        public int gridY;

        public AnimationSet()
        {

        }

        public AnimationSet(int inputWidth, int inputHeight, int inputGridX, int inputGridY)
        {
            width = inputWidth;
            height = inputHeight;
            gridX = inputGridX;
            gridY = inputGridY;
        }

    }

    public class AnimationData
    {
        public AnimationSet animation { get; set; }
        public string texturePath { get; set; }
    }
}
