using System;

namespace BowlingKata
{
   public class Bowling
    {
        public int CalcScore(int[] scoresArray)
        { 
            var score = 0;
            var maxThrows = 21;

            for(int roll = 0, frames = 1; roll<maxThrows-1; roll+=2, frames++)
            {
                var frameScore = scoresArray[roll] + scoresArray[roll + 1];
                if(frameScore == 10 && frames!=10)
                {
                    if(scoresArray[roll] == 10)
                    {
                        //strike logic
                        score+=10;
                        score += scoresArray[roll+2];
                        score += scoresArray[roll+3];
                        Console.WriteLine("Frame: " + frames  + " Score " + score);

                    }
                    else
                    {
                        //spare logic
                        score +=10;
                        score +=scoresArray[roll+2];
                        Console.WriteLine("Frame: " + frames  + " Score " + score);
                    }
                }
                else if(frameScore >= 10 && frames==10)
                {
                    if(scoresArray[roll] == 10 && scoresArray[roll+1]==10)
                    {
                        score+=30;
                        score+=scoresArray[roll+2]*3;
                        //Console.WriteLine("PG score: " +  score);
                            Console.WriteLine("Frame: " + frames  + " Score " + score);

                    }
                    else if(scoresArray[roll]==10)
                    {
                        score+=10;
                        score+=scoresArray[roll+2]*2;
                        score+=scoresArray[roll+3]*2;
                                                Console.WriteLine("Frame: " + frames  + " Score " + score);

                    }
                    else
                    {
                        score +=10;
                        score +=scoresArray[roll+2];
                                                Console.WriteLine("Frame: " + frames  + " Score " + score);

                    }

                }

                else
                {
                    score += frameScore;
                    Console.WriteLine("Frame: " + frames  + " Score " + score);

                }

            }
                //Console.WriteLine("Frame: " + frames);
                //Console.WriteLine(frameScore);
            
            
            return score;
        }

        public int Spare(int[]scoresArray, int frame)
        {
            int spareScore =0;
            return spareScore;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          var inputArray = new int[]{1,4,4,5,6,4,5,5,10,0,0,1,7,3,6,4,10,0,2,8,6};
           //var inputArray = new int[]{10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,10,10};

            var scoreCalculator = new Bowling();
            Console.WriteLine(scoreCalculator.CalcScore(inputArray));
        }
    }
}
