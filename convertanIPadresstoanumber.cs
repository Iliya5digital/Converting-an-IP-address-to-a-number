private static int IPToInt(IPAddress ip)
{
  byte[] ip_bytes = ip;
  int iip = ip_bytes[0] << 24;
  iip |= ip_bytes[1] << 16;
  iip |= ip_bytes[2] << 8;
  iip |= ip_bytes[3];
  return iip;
}
