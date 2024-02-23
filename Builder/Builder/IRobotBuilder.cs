
namespace Builder
{
    // Builder
    public interface IRobotBuilder
    {
        void BuildHead(string head);
        void BuildBody(string body);
        void BuildArms(string arms);
        void BuildLegs(string legs);

        Robot GetRobot();
    }
}
