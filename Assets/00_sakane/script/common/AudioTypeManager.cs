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
		C			= 0,  // �h
		CSharp		= 1,  // �h��
		DFlat		= 2,  // ����
		D			= 3,  // ��
		DSharp		= 4,  // ����
		EFlat		= 5,  // �~��
		E			= 6,  // �~
		ESharp		= 7,  // �~���i�t�@�j
		F			= 8,  // �t�@
		FSharp		= 9,  // �t�@��
		GFlat		= 10, // �\��
		G			= 11, // �\
		GSharp		= 12, // �\��
		AFlat		= 13, // ����
		A			= 14, // ��
		ASharp		= 15, // ����
		BFlat		= 16, // �V��
		B			= 17, // �V
		BSharp		= 18, // �V��
		CCode		= 19, // C�R�[�h	�i�h�A		�~�A	�\�j
		CSharpCode	= 20, // C���R�[�h	�i�h���A	�~���A	�\���j
		DFlatCode	= 21, // C��R�[�h	�i����A	�t�@�A	����j
		DCode		= 22, // D�R�[�h	�i���A		�t�@���A���j
		DSharpCode	= 23, // D���R�[�h	�i�����A	�\�A	�����j
		EFlatCode	= 24, // E��R�[�h	�i�~��A	�\�A	�V��j
		ECode		= 25, // E�R�[�h	�i�~�A		�\���A	�V�j
		FCode		= 26, // F�R�[�h	�i�t�@�A	���A	�h�j
		FSharpCode	= 27, // F���R�[�h	�i�t�@���A	�����A	�h���j
	}
}
