﻿//public delegate int WorkPerformedHandler(int hours);

public class Worker
{
    public event EventHandler<WorkPerformedEventArgs>? WorkPerformed;

    public event EventHandler? workCompleted;

    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            Thread.Sleep(1000);
            OnWorkPerformed(i + 1, workType);
        }

        OnWorkCompleted();
    }

    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    {
        WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
    }

    protected virtual void OnWorkCompleted()
    {
        workCompleted?.Invoke(this, EventArgs.Empty);
    }
}