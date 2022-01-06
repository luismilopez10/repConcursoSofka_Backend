CREATE PROCEDURE [dbo].[spaConsultarPreguntaNivel]
	@intNivel INT = 0
AS
	BEGIN
		SELECT 
			intIdPregunta, 
			tblPregunta.intIdCategoria, 
			strPregunta,
			strRespuesta,
			tblPregunta.blnActivo,
			tblPregunta.dtmActualiza
		FROM dbo.tblPregunta INNER JOIN dbo.tblCategoria ON dbo.tblPregunta.intIdCategoria = dbo.tblCategoria.intIdCategoria
		WHERE tblPregunta.blnActivo = 1
		AND tblCategoria.intNivel = @intNivel
	END