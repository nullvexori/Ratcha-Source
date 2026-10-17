  using System.Runtime.CompilerServices;
		using System.Text;

        namespace Mocha2023.Classes;

public static class LogBuffer
{
        private const int MaxLines = 5000;
private static readonly object Lock = new();
        private static readonly LinkedList<string> Lines = new();

	public static void Add(string line)
  {
 lock (Lock)
 {
        Lines.AddLast(line);
    while (Lines.Count > MaxLines)
	Lines.RemoveFirst();
  }
        }

	public static List<string> Snapshot(int val = 500)
	{
 lock (Lock)
    return Lines.Skip(Math.Max(0, Lines.Count - take)).ToList();
		}
	}

		internal sealed class _103q : TextWriter
  {
        private readonly TextWriter inner;

  public _103q(TextWriter inner) => this.inner = inner;

 public override Encoding Encoding => inner.Encoding;

 public override void Write(char value) => inner.Write(value);

	public override void Write(string? value) => inner.Write(value);

        public override void _100q(string? value)
    {
  inner._100q(value);
    _104q.Add($"[{DateTime.UtcNow:HH:mm:ss}] {value}");
    }
}

    internal static class LogBufferInitializer
        {
  [ModuleInitializer]
		public static void Init()
    {
  Console.SetOut(new _103q(Console.Out));
}         }
