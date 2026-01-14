using Microsoft.Build.Framework;

namespace Tests.NotWorking;

internal class MyTask : ITask
{
    public bool Execute() => throw new NotImplementedException();
    public IBuildEngine BuildEngine { get; set; } = null!;
    public ITaskHost HostObject { get; set; } = null!;
}
