namespace Prism
{
	internal record AssetMetaData(ulong Uid, ulong Magic, uint ContainerType, string _filename) {
		public string Filename {
			get {
				return _filename == "" ? string.Format("0x{0:X}", Uid) : _filename;
			}
		}
	}
}