using System.Buffers.Binary;

Span<byte> bytes = stackalloc byte[4];
while (true)
{
    Console.Write("Enter a number or a Base64 string: ");
    var input = Console.ReadLine()?.Trim();
    if (string.IsNullOrWhiteSpace(input))
        continue;
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
        return;

    var result = string.Empty;
    if (int.TryParse(input, out var number))
    {
        BinaryPrimitives.WriteInt32LittleEndian(bytes, number);
        result = Convert.ToBase64String(bytes);
    }
    else if (Convert.TryFromBase64String(input, bytes, out var length))
    {
        result = BinaryPrimitives.ReadInt32LittleEndian(bytes).ToString();
    }
    Console.WriteLine(result);
}