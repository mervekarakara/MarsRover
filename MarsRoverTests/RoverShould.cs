using Xunit;
using MarsRover;
using System;

namespace MarsRoverTests
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            //Arrange
            Rover rover = new Rover("1 2 N");
            //Act 
            rover.SpinLeft();
            //Assert
            Assert.Equal("W",rover.direction);

        }
        [Fact]
        public void SpinRight()
        {
            //Arrange
            Rover rover = new Rover("1 2 N");
            //Act : 
            rover.SpinRight();
            //Assert
            Assert.Equal("E", rover.direction);

        }
        [Fact]
        public void StepForward()
        {
            //Arrange 
            Rover rover = new Rover("1 2 N");
            //Act : 
            rover.StepForward();
            //Assert
            Assert.Equal(3, rover.y);

        }
        [Fact]
        public void Move()
        {
            //Arrange 
            Rover rover = new Rover("1 2 N");
            //Act  
            rover.Move("LMLMLMLMM");
            //Assert
            Assert.Equal("1 3 N", rover.x+" "+rover.y+" "+rover.direction);

        }
        [Fact]
        public void Move2()
        {
            //Arrange 
            Rover rover = new Rover("3 3 E");
            //Act  
            rover.Move2("MMRMMRMRRM");
            //Assert
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);

        }

    }
}