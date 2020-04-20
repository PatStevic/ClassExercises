using System;

namespace LabNumber._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n\nWe are planning on painting the rooms here at Grand Circus and we need your help! \nHelp us add some color to Grand Circus by measuring some rooms. \n \nCan you tell us the length of your classroom in feet? (please use a numeric value as you are entering measurements)");
                string userClassroomLength = Console.ReadLine();
                decimal classroomLengthResponse = decimal.Parse(userClassroomLength);

                Console.WriteLine("Can you tell us the width of the room?");
                string userClassroomWidth = Console.ReadLine();
                decimal classroomWidthResponse = decimal.Parse(userClassroomWidth);


                decimal classRoomArea = classroomLengthResponse * classroomWidthResponse;
                decimal classRoomPerimeter = (2 * (classroomLengthResponse + classroomWidthResponse));

                Console.WriteLine("Nice, thanks for helping!\n\nRoom: Classroom\nClassroom Area: " + classRoomArea + " ft\nClassroom Perimeter: " + classRoomPerimeter + " ft");
                Console.WriteLine("\n\nWould you like to continue helping us measure rooms? (y/n)");
                string wouldTheUderLikeToContinue = Console.ReadLine();

                string userWantsToContinue;
                do
                {
                    Console.WriteLine("\n\nEnter the name of the next room you are about to measure (Kitchen, Breakroom, Reception Area, Etc...)");
                    string roomName = Console.ReadLine();

                    Console.WriteLine("\nWhat is the length of the room?");
                    string roomLength = Console.ReadLine();
                    decimal roomLengthResponse = decimal.Parse(roomLength);

                    Console.WriteLine("\nWhat is the width of the room?");
                    string roomWidth = Console.ReadLine();
                    decimal roomWidthRespoinse = decimal.Parse(roomWidth);


                    decimal roomArea = roomLengthResponse * roomWidthRespoinse;
                    decimal roomPerimeter = (2 * (classroomLengthResponse + classroomWidthResponse));


                    Console.WriteLine("\n\nRoom: " + roomName + "\n" + roomName + " Area: " + roomArea + " ft" + "\n" + roomName + " Perimeter: " + roomPerimeter + " ft");
                    Console.WriteLine("\n\nWould you like to continue with another room (Y/N)?");
                    userWantsToContinue = Console.ReadLine();

                }

                while (userWantsToContinue.ToLower() == "y");

                Console.WriteLine("\n\nThanks for helping!\nThis place is going to look great!");

            }

            catch
            {
                Console.WriteLine("\n\nHey now... thats not a proper value. Lets try this again... ");

                Console.WriteLine("\n\nCan you tell us the length of your classroom in feet? (please use a numeric value as you are entering measurements)");
                string userClassroomLength = Console.ReadLine();
                decimal classroomLengthResponse = decimal.Parse(userClassroomLength);

                Console.WriteLine("Can you tell us the width of the room?");
                string userClassroomWidth = Console.ReadLine();
                decimal classroomWidthResponse = decimal.Parse(userClassroomWidth);


                decimal classRoomArea = classroomLengthResponse * classroomWidthResponse;
                decimal classRoomPerimeter = (2 * (classroomLengthResponse + classroomWidthResponse));

                Console.WriteLine("Nice, thanks for helping!\n\nRoom: Classroom\nClassroom Area: " + classRoomArea + " ft\nClassroom Perimeter: " + classRoomPerimeter + " ft");
                Console.WriteLine("\n\nWould you like to continue helping us measure rooms? (y/n)");
                string wouldTheUderLikeToContinue = Console.ReadLine();

                string userWantsToContinue;
                do
                {
                    Console.WriteLine("\n\nEnter the name of the next room you are about to measure (Kitchen, Breakroom, Reception Area, Etc...)");
                    string roomName = Console.ReadLine();

                    Console.WriteLine("\nWhat is the length of the room?");
                    string roomLength = Console.ReadLine();
                    decimal roomLengthResponse = decimal.Parse(roomLength);

                    Console.WriteLine("\nWhat is the width of the room?");
                    string roomWidth = Console.ReadLine();
                    decimal roomWidthRespoinse = decimal.Parse(roomWidth);


                    decimal roomArea = roomLengthResponse * roomWidthRespoinse;
                    decimal roomPerimeter = (2 * (classroomLengthResponse + classroomWidthResponse));


                    Console.WriteLine("\n\nRoom: " + roomName + "\n" + roomName + " Area: " + roomArea + " ft" + "\n" + roomName + " Perimeter: " + roomPerimeter + " ft");
                    Console.WriteLine("\n\nWould you like to continue with another room (Y/N)?");
                    userWantsToContinue = Console.ReadLine();

                }

                while (userWantsToContinue.ToLower() == "y");

                Console.WriteLine("\n\nThanks for helping!\nThis place is going to look great!");

            }

            //if (wouldTheUderLikeToContinue.ToLower() == "y")
            //    {
            //    Console.WriteLine("Sweet! Enter the name of the next room you are about to measure (Kitchen, Breakroom, Reception Area, Etc...)");
            //    string roomOneName = Console.ReadLine();

            //    Console.WriteLine("What is the length of the room?");
            //    string roomOneLength = Console.ReadLine();
            //    decimal roomOneLengthRespoinse = decimal.Parse(roomOneLength);

            //    Console.WriteLine("What is the width of the room?");
            //    string roomOneWidth = Console.ReadLine();
            //    decimal roomOneWidthRespoinse = decimal.Parse(roomOneWidth);
            //    }


            //else
            //{
            //    console.writeline("i get it you're prob busy learning how to code. thanks anyways!");
            //}
            // Console.WriteLine("Would you like to continue helping us measure rooms? (y/n)");
            // Console.WriteLine("I get it you're prob busy learning how to code. Thanks Anyways!");
        }
    }
}