using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jetsons.JetPack;

namespace Jetsons.JetPack {
	public static class ImageBytes {

		/// <summary>
		/// Encode the Bitmap object into a compressed PNG image file. Never returns null.
		/// </summary>
		public static byte[] EncodePNG(this Bitmap bitmap, int quality = 100) {
			using (var mem = new MemoryStream()) {
				var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Png.Guid);
				var encParams = new EncoderParameters(1);
				encParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)quality);
				bitmap.Save(mem, encoder, encParams);
				return mem.ToBytes();
			}
		}

		/// <summary>
		/// Encode the Bitmap object into a compressed PNG image file. Never returns null.
		/// </summary>
		public static byte[] EncodeJPG(this Bitmap bitmap, int quality = 100) {
			using (var mem = new MemoryStream()) {
				var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
				var encParams = new EncoderParameters(1);
				encParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)quality);
				bitmap.Save(mem, encoder, encParams);
				return mem.ToBytes();
			}
		}

		/// <summary>
		/// Encode the Bitmap object into an uncompressed BMP image file. Never returns null.
		/// </summary>
		public static byte[] EncodeBMP(this Bitmap bitmap) {
			using (var mem = new MemoryStream()) {
				bitmap.Save(mem, ImageFormat.Bmp);
				return mem.ToBytes();
			}
		}

		/// <summary>
		/// Encode the Icon object into an uncompressed ICO formatted image data. Never returns null.
		/// </summary>
		public static byte[] EncodeICO(this Icon bitmap) {
			using (var mem = new MemoryStream()) {
				bitmap.Save(mem);
				return mem.ToBytes();
			}
		}

		/// <summary>
		/// Decode the binary data into a Bitmap object. Supports PNG, JPG, GIF, EXIF and various other image formats.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap DecodeBitmap(this byte[] bytes) {
			try {
				return new Bitmap(bytes.ToStream());
			}
			catch (Exception) { }
			return null;
		}

		/// <summary>
		/// Decode the PNG image data into a Bitmap object.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap DecodePNG(this byte[] bytes) {
			return bytes.DecodeBitmap();
		}

		/// <summary>
		/// Decode the JPG image data into a Bitmap object.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap DecodeJPG(this byte[] bytes) {
			return bytes.DecodeBitmap();
		}

		/// <summary>
		/// Decode the BMP image data into a Bitmap object.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap DecodeBMP(this byte[] bytes) {
			return bytes.DecodeBitmap();
		}

		/// <summary>
		/// Decode the ICO formatted file data into a Icon object.
		/// Returns null if the icon cannot be decoded or is an unsupported type.
		/// </summary>
		public static Icon DecodeICO(this byte[] bytes) {
			try {
				return new Icon(bytes.ToStream());
			}
			catch (Exception) { }
			return null;
		}


	}
}
