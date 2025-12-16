using System;
using System.Runtime.InteropServices;
using System.Text;

public static class j7xqcJiG4H
{
    public unsafe static string wUK(int lgFaCzXanNo)
    {
        bool isNegative = (lgFaCzXanNo >> 31 != 0);
        if (isNegative)
            return string.Empty;

        byte* ptr = (byte*)(&j7xqcJiG4H.HZcFo);
        ptr += (lgFaCzXanNo ^ *(int*)ptr);

        int length = *(int*)ptr;
        byte[] buffer = new byte[length];

        fixed (byte* bufferPtr = &buffer[0])
        {
            cpblk(bufferPtr, ptr + 8, length);
        }

        bool isOdd = (buffer.Length % 2 != 0);
        if (isOdd)
        {
            int mid = buffer.Length >> 1;
            buffer[mid] ^= *(int*)(ptr + 4);
        }

        int end = buffer.Length - 1;
        for (int i = 0; i <= end; i++)
        {
            buffer[i] ^= (byte)((int)buffer[end] ^ *(int*)(ptr + 4));
            end--;
        }

        return string.Intern(Encoding.UTF8.GetString(buffer));
    }

    private static j7xqcJiG4H.KSi4QsZ HZcFo;

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19409)]
	private struct KSi4QsZ
	{
	}
}
