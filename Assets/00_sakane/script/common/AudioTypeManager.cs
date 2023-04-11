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
		C		= 0,  // ド
		CSharp	= 1,  // ド＃
		DFlat	= 2,  // レ♭
		D		= 3,  // レ
		DSharp	= 4,  // レ＃
		EFlat	= 5,  // ミ♭
		E		= 6,  // ミ
		ESharp	= 7,  // ミ＃（ファ）
		F		= 8,  // ファ
		FSharp	= 9,  // ファ＃
		GFlat	= 10, // ソ♭
		G		= 11, // ソ
		GSharp	= 12, // ソ＃
		AFlat	= 13, // ラ♭
		A		= 14, // ラ
		ASharp	= 15, // ラ＃
		BFlat	= 16, // シ♭
		B		= 17, // シ
		BSharp	= 18, // シ＃
	}

	// MajorChord
	public enum MajorCodeType
	{
		CChord		= 0,  // Cコード	（ド、		ミ、	ソ）
		CSharpChord = 1,  // C＃コード	（ド＃、	ミ＃、	ソ＃）
		DFlatChord	= 2,  // C♭コード	（レ♭、	ファ、	ラ♭）
		DChord		= 3,  // Dコード	（レ、		ファ＃、ラ）
		DSharpChord = 4,  // D＃コード	（レ＃、	ソ、	ラ＃）
		EFlatChord	= 5,  // E♭コード	（ミ♭、	ソ、	シ♭）
		EChord		= 6,  // Eコード	（ミ、		ソ＃、	シ）
		FChord		= 7,  // Fコード	（ファ、	ラ、	ド）
		FSharpChord = 8,  // F＃コード	（ファ＃、	ラ＃、	ド＃）
		GFlatChord	= 9,  // G♭コード	（ソ♭、	シ♭、	レ♭）
		GChord		= 10, // Gコード	（ソ、		シ、	レ）
		GSharpShord = 11, // G＃コード	（ソ＃、	シ＃、	レ＃）
		AFlatShord	= 12, // A♭コード	（ラ♭、	ド、	ミ♭）
		AShord		= 13, // Aコード	（ラ、		ド＃、	ミ）
		ASharpShord	= 14, // A＃コード	（ラ＃、	レ、	ファ）
		BFlatShord	= 15, // B♭コード	（シ♭、	レ、	ファ）
		BShord		= 16, // Bコード	（シ、		レ＃、	ファ＃）

	}
}
