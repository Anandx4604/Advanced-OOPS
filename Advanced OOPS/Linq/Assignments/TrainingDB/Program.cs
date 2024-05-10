using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            // Press 10 to show the first Trainee Id and Trainee Name
            // Press 11 to show the last Trainee Id and Trainee Name
            // Press 12 to print the total score of each trainee
            // Press 13 to show the maximum total score
            // Press 14 to show the minimum total score
            // Press 15 to show the average of total score
            // Press 16 to show true or false if any one has the more than 40 score using any()
            // Press 17 to show true of false if all of them has the more than 20 using all()
            // Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.

            //creating new object 
            TraineeData traineeData = new TraineeData();
            List<TraineeDetails> traineeList = traineeData.GetTraineeDetails();
            // TraineeDetails<List<TraineeScore>> traineeAndScoreList = new TraineeDetails<List<TraineeScore>>();
            System.Console.WriteLine("Training Details");
            System.Console.WriteLine("1.Trainee ID list 2.First 3 Trainee ID 3.Last 2 Trainee ID 4.Count of Trainee 5.Trainee Passed Out - 2019 6.Trainee ID by Alphabetical Order 7.");
            System.Console.Write("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                // Press 1 to Show the list of Trainee Id
                case 1:
                    {
                        var traineeIDlist = from trainee in traineeList
                                            select trainee.TraineeId;

                        System.Console.WriteLine("Trainee Details in Alphabetical Order:");
                        foreach (var traineeIDs in traineeIDlist)
                        {
                            System.Console.WriteLine(traineeIDs);
                        }
                        break;
                    }

                //Press 2 to Show the first 3 Trainee Id using Take
                case 2:
                    {
                        var firstThreeTraineeID = traineeList.Take(3);
                        foreach (var threeIDs in firstThreeTraineeID)
                        {
                            System.Console.WriteLine(threeIDs.TraineeId);
                        }
                        break;
                    }
                //Press 3 to show the last 2 Trainee Id using Skip
                case 3:
                    {
                        var lastTwoTraineeID = traineeList.Skip(3); //skips the first 3 ids here
                        foreach (var lastIDs in lastTwoTraineeID)
                        {
                            System.Console.WriteLine(lastIDs.TraineeId);
                        }
                        break;
                    }
                //Press 4 to show the count of Trainee 
                case 4:
                    {
                        var traineeCount = traineeList.Count();
                        System.Console.WriteLine($"Total Trainee Count:{traineeCount}");
                        break;
                    }
                // Press 5 to show the Trainee Name who are all passed out 2019 or later
                case 5:
                    {
                        var passedOut2019 = from traineeName in traineeList
                                            where traineeName.YearPassedOut >= 2019
                                            select traineeName;

                        System.Console.WriteLine("Trainees PassedOut 2019 or Later:");
                        foreach (var names in passedOut2019)
                        {
                            System.Console.WriteLine(names.TraineeName);
                        }
                        break;
                    }
                // Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.
                case 6:
                    {
                        var traineeNameOrder = from traineeName in traineeList
                                               orderby traineeName.TraineeName // by default orderby returns in ascending order
                                               select traineeName;
                        foreach (var namesInOrder in traineeNameOrder)
                        {
                            System.Console.WriteLine($"Trainee ID: {namesInOrder.TraineeId}  Name: {namesInOrder.TraineeName}");
                        }
                        break;
                    }
                // Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name 
                // and Mark who are all scores the more than or equal to 4 mark
                case 7:
                    {
                        var result = traineeList.SelectMany(trainee => trainee.ScoreDetails.Where(score => score.Mark >= 4), (trainee, score) => new { trainee.TraineeName, trainee.TraineeId, trainee.ScoreDetails, score.TopicName, score.ExerciseName, score.Mark });

                        foreach (var marks in result)
                        {
                            System.Console.WriteLine($"|{marks.TraineeId} | {marks.TraineeName} | {marks.TopicName} | {marks.ExerciseName} | {marks.Mark}");
                        }
                        break;
                    }
                // Press 8 to show the unique passed out year using distinct
                case 8:
                    {
                        var uniquePassedoutYear = (from years in traineeList
                                                   select years.YearPassedOut).Distinct();
                        foreach (var years in uniquePassedoutYear)
                        {
                            System.Console.WriteLine(years);
                        }
                        break;
                    }
                // Press 9 to show the total marks of single user(get the Trainee Id from User), if Trainee Id does not exist, show the invalid message
                case 9:
                    {
                        foreach (var trainee in traineeList)
                        {
                            System.Console.WriteLine($"{trainee.TraineeId} | {trainee.TraineeName} | ");
                        }
                        System.Console.WriteLine("Enter a TraineeID:");
                        string traineeID = Console.ReadLine();
                        var checkID = traineeList.FirstOrDefault(trainee => trainee.TraineeId == traineeID);
                        if (checkID != null)
                        {
                            int score = checkID.ScoreDetails.Sum(trainee=>trainee.Mark);
                            System.Console.WriteLine($"Training ID:{traineeID} Total Mark:{score}");
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid Trainee ID!");
                        }
                        break;
                    }

                case 10:
                    {
                        break;
                    }

                case 11:
                    {
                        break;
                    }

                case 12:
                    {
                        break;
                    }

                case 13:
                    {
                        break;
                    }

                case 14:
                    {
                        break;
                    }
                case 15:
                    {
                        break;
                    }
                case 16:
                    {
                        break;
                    }
                case 17:
                    {
                        break;
                    }
                case 18:
                    {
                        break;
                    }




            }
        }
    }
}
