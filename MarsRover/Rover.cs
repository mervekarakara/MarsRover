using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {

        public int x; //rover ın x kordinatı
        public int y; //rover ın y kordinatı
        public string direction; //rover ın ana kordinatı
        public Rover(string location) //location="1 2 N"
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction=location.Split(" ")[2];

        }
        public void SpinLeft() 
        {
            switch (direction)
            {
                case "N":
                    direction="W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }

        }

        public void Move(string roverCommand) 
        {
            //LMLMLMLMM 
            char[] instructions=roverCommand.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public void Move2(string roverCommand)
        {
            //MMRMMRMRRM
            char[] instructions = roverCommand.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

    }
}
