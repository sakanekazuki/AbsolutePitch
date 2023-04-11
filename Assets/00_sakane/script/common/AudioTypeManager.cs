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
		C		= 0,  // �h
		CSharp	= 1,  // �h��
		DFlat	= 2,  // ����
		D		= 3,  // ��
		DSharp	= 4,  // ����
		EFlat	= 5,  // �~��
		E		= 6,  // �~
		ESharp	= 7,  // �~���i�t�@�j
		F		= 8,  // �t�@
		FSharp	= 9,  // �t�@��
		GFlat	= 10, // �\��
		G		= 11, // �\
		GSharp	= 12, // �\��
		AFlat	= 13, // ����
		A		= 14, // ��
		ASharp	= 15, // ����
		BFlat	= 16, // �V��
		B		= 17, // �V
		BSharp	= 18, // �V��
	}

	// MajorChord
	public enum MajorCodeType
	{
		CChord		= 0,  // C�R�[�h	�i�h�A		�~�A	�\�j
		CSharpChord = 1,  // C���R�[�h	�i�h���A	�~���A	�\���j
		DFlatChord	= 2,  // C��R�[�h	�i����A	�t�@�A	����j
		DChord		= 3,  // D�R�[�h	�i���A		�t�@���A���j
		DSharpChord = 4,  // D���R�[�h	�i�����A	�\�A	�����j
		EFlatChord	= 5,  // E��R�[�h	�i�~��A	�\�A	�V��j
		EChord		= 6,  // E�R�[�h	�i�~�A		�\���A	�V�j
		FChord		= 7,  // F�R�[�h	�i�t�@�A	���A	�h�j
		FSharpChord = 8,  // F���R�[�h	�i�t�@���A	�����A	�h���j
		GFlatChord	= 9,  // G��R�[�h	�i�\��A	�V��A	����j
		GChord		= 10, // G�R�[�h	�i�\�A		�V�A	���j
		GSharpShord = 11, // G���R�[�h	�i�\���A	�V���A	�����j
		AFlatShord	= 12, // A��R�[�h	�i����A	�h�A	�~��j
		AShord		= 13, // A�R�[�h	�i���A		�h���A	�~�j
		ASharpShord	= 14, // A���R�[�h	�i�����A	���A	�t�@�j
		BFlatShord	= 15, // B��R�[�h	�i�V��A	���A	�t�@�j
		BShord		= 16, // B�R�[�h	�i�V�A		�����A	�t�@���j

	}
}
