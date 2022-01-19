CREATE PROCEDURE [dbo].[spaConsultarJugador]
AS
	BEGIN
		SELECT 
			intIdJugador, 
			intPuntaje, 
			strNombre,
			blnActivo,
			dtmActualiza
		FROM dbo.tblJugador
		WHERE blnActivo = 1
	END