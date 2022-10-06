<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	byte? nextByte = new byte();
	using (var steam = new ByteSteam(File.OpenRead(@"D:\source\repos\Linq\CSharpInDepth4SampleCodes\Chapter5\anonMethod.linq")))
	{
		while ((nextByte = await steam.ReadByteAsync()).HasValue)
		{
			Console.WriteLine(nextByte.Value);
		}
	}
}

public sealed class ByteSteam : IDisposable
{
	private readonly Stream steam;
	private readonly byte[] buffer;
	private int position; //待返回的缓冲区下一个索引
	private int bufferedBytes; //缓冲区读取的字节数

	public ByteSteam(Stream stream)
	{
		this.steam = stream;
		buffer = new byte[1024 * 8]; //8KB缓冲区
	}

	public async ValueTask<byte?> ReadByteAsync()
	{
		if (position == bufferedBytes)
		{
			position = 0;
			bufferedBytes = await steam.ReadAsync(buffer, 0, buffer.Length) //从流中异步读取
									   .ConfigureAwait(false);  //配置await操作忽略上下文
			if (bufferedBytes == 0)
			{
				return null; // 读取到流末尾
			}
		}
		return buffer[position++];
	}

	public void Dispose()
	{
		steam.Dispose();
	}
};
