﻿namespace FastEngine.Core.I18n
{
	public class Excel2Text
	{
		public Excel2Text(ExcelReader reader)
		{
			FilePathUtils.DirectoryClean(AppUtils.i18nDataDirectory());

			for (int i = 0; i < reader.sheets.Length; i++)
			{
				var sheet = reader.sheets[i];
				for (int l = 0; l < reader.options.languages.Count; l++)
				{
					var language = reader.options.languages[l];

					FilePathUtils.FileWriteAllText(FilePathUtils.Combine(AppUtils.i18nDataDirectory(), language.ToString(), i.ToString() + ".txt"), sheet.ToValueString(l + 1));
				}
			}
		}
	}
}