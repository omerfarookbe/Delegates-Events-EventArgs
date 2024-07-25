public class WorkPerformedEventArgs
{
    public int Hours { get; set; }

    public WorkType WorkType { get; set; }

    public WorkPerformedEventArgs(int _hours, WorkType _worktype) => (Hours, WorkType) = (_hours, _worktype);
}