public class AudioTypeManager
{
	// instrument type
	public enum InstrumentType
	{
		Piano = 0,
	}

	// SoundType
	public enum SoundType
	{
		C			= 0,  // ド
		CSharp		= 1,  // ド＃
		DFlat		= 2,  // レ♭
		D			= 3,  // レ
		DSharp		= 4,  // レ＃
		EFlat		= 5,  // ミ♭
		E			= 6,  // ミ
		ESharp		= 7,  // ミ＃（ファ）
		F			= 8,  // ファ
		FSharp		= 9,  // ファ＃
		GFlat		= 10, // ソ♭
		G			= 11, // ソ
		GSharp		= 12, // ソ＃
		AFlat		= 13, // ラ♭
		A			= 14, // ラ
		ASharp		= 15, // ラ＃
		BFlat		= 16, // シ♭
		B			= 17, // シ
		BSharp		= 18, // シ＃
		CCode		= 19, // Cコード（ド、ミ、ソ）
		CSharpCode	= 20, // C＃コード（ド＃、ミ＃、ソ＃）
		DFlatCode	= 21, // C♭コード（レ♭、ファ、ラ♭）
		DCode		= 22, // Dコード（レ、ファ＃、ラ）
	}
}
