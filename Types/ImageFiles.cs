using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jetsons.JetPack {
	public static class ImageFiles {
		
		/// <summary>
		/// Saves the Bitmap object into a compressed PNG image file.
		/// </summary>
		/// <param name="bitmap">Bitmap object</param>
		/// <param name="fileName">File path, overwritten if it already exists</param>
		/// <param name="createFolder">Create the parent folder?</param>
		/// <param name="quality">Image quality measured from 0-100. Affects image compression and file size.</param>
		public static void SaveToPNG(this Bitmap bitmap, string fileName, bool createFolder = true, int quality = 100) {
			var bytes = bitmap.EncodePNG(quality);
			bytes.SaveToFile(fileName, createFolder);
		}

		/// <summary>
		/// Saves the Bitmap object into a compressed PNG image file.
		/// </summary>
		/// <param name="bitmap">Bitmap object</param>
		/// <param name="fileName">File path, overwritten if it already exists</param>
		/// <param name="createFolder">Create the parent folder?</param>
		/// <param name="quality">Image quality measured from 0-100. Affects image compression and file size.</param>
		public static void SaveToJPG(this Bitmap bitmap, string fileName, bool createFolder = true, int quality = 100) {
			var bytes = bitmap.EncodeJPG(quality);
			bytes.SaveToFile(fileName, createFolder);
		}

		/// <summary>
		/// Saves the Bitmap object into an uncompressed BMP image file.
		/// </summary>
		/// <param name="bitmap">Bitmap object</param>
		/// <param name="fileName">File path, overwritten if it already exists</param>
		/// <param name="createFolder">Create the parent folder?</param>
		public static void SaveToBMP(this Bitmap bitmap, string fileName, bool createFolder = true) {
			var bytes = bitmap.EncodeBMP();
			bytes.SaveToFile(fileName, createFolder);
		}

		/// <summary>
		/// Saves the Icon object into an ICO formatted image file.
		/// </summary>
		/// <param name="icon">Icon object</param>
		/// <param name="fileName">File path, overwritten if it already exists</param>
		/// <param name="createFolder">Create the parent folder?</param>
		public static void SaveToICO(this Icon icon, string fileName, bool createFolder = true) {
			var bytes = icon.EncodeICO();
			bytes.SaveToFile(fileName, createFolder);
		}

		/// <summary>
		/// Load the image file into a Bitmap object. Supports PNG, JPG, GIF, EXIF and various other image formats.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap LoadBitmap(this string fileName) {
			var bytes = fileName.LoadBytes();
			if (bytes != null) {
				try {
					return new Bitmap(bytes.ToStream());
				}
				catch (Exception) { }
			}
			return null;
		}

		/// <summary>
		/// Load the PNG image file into a Bitmap object.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap LoadPNG(this string fileName) {
			return fileName.LoadBitmap();
		}

		/// <summary>
		/// Load the JPG image file into a Bitmap object.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap LoadJPG(this string fileName) {
			return fileName.LoadBitmap();
		}

		/// <summary>
		/// Load the BMP image file into a Bitmap object.
		/// Returns null if the image cannot be decoded or is an unsupported type.
		/// </summary>
		public static Bitmap LoadBMP(this string fileName) {
			return fileName.LoadBitmap();
		}

		/// <summary>
		/// Load the ICO formatted icon into an Icon object.
		/// Returns null if the icon cannot be decoded or is an unsupported type.
		/// </summary>
		public static Icon LoadICO(this string fileName) {
			var bytes = fileName.LoadBytes();
			if (bytes != null) {
				try {
					return new Icon(bytes.ToStream());
				}
				catch (Exception) { }
			}
			return null;
		}
		
	}
}
