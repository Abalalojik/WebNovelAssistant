using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using lvgcs = System.Windows.Forms.ListViewGroupCollapsedState;

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
