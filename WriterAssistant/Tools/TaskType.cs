using System.ComponentModel;

namespace WebNovelAssistant.Tools
{
    public class Tasks
    {
        public enum TaskType
        {
            [Description("Priority Task")]
            PriorityTask,

            [Description("Regular Task")]
            RegularTask,

            [Description("User Tasks")]
            UserTasks,

            [Description("Automated Tasks")]
            AutomatedTasks
        }
    }
}
