// See https://aka.ms/new-console-template for more information

namespace Bouncing_Balls
{
    public static class BouncingBall
    {
        public static int BallBouncing(float ballStartHeight, float bounceRate, float windowsHeight)
        {
            var icorrectParameter = -1;
            
            if (ballStartHeight > 0 && bounceRate is > 0 and < 1 && ballStartHeight - windowsHeight > 0)
            {
                var result = 1;
                var ballBounce = ballStartHeight * bounceRate;
                while (ballBounce >= windowsHeight)
                {
                    result += 2;
                    ballBounce *= bounceRate;
                    Console.WriteLine(ballBounce);
                }
                return result;
            }
            else return icorrectParameter;
        }
    }
}