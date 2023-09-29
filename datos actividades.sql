select * from Prod.LimpArea
--Areas--
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('ADIPA', 'ADIPACK', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('RECEP_M.P', 'RECEPCIÓN M.P', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('ESTER_UHT_P1', 'ESTERILIZACIÓN UHT PLANTA 1', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('LLENAD_TBA_19', 'LLENADORA TBA 19', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('LLENAD_TBA_9', 'LLENADORA TBA 9', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('LLENAD_S8', 'LLENADORA S8', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('ESTER_2', 'ESTERILIZACION 2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
INSERT INTO [Prod].[LimpArea] ([CodArea], [Descripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion])
VALUES ('PASTE_PL2', 'PASTEURIZACIÓN PL2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE());
--Formularios--
=====================================
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-025', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'ADIPA');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-031', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'RECEP_M.P');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-029', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'ESTER_UHT_P1');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-028', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'LLENAD_TBA_19');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-027', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'LLENAD_TBA_9');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('CC.R 04.35', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'LLENAD_S8');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('CC.R 04.10', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'ESTER_2');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-023', 'LIMPIEZA Y DESINFECCIÓN ', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'PASTE_PL2');
INSERT INTO [Prod].[LimpFormulario] ([CodFormulario], [Descripcion], [CreadoPor], [FechaHoraCreacion], [ActualizadoPor], [FechaHoraActualizacion], [CodEmpresa], [CodArea])
VALUES ('T-PRO-RE-025', 'VERIFICACIÓN DE LIMPIEZA Y DESINFECCIÓN FORMA DE LLENADO', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 'PQSA', 'ADIPA');

--Actividades T-PRO-RE-025

INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso  ADIPACK', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 1, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Banda trasportadora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 2, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso  banda trasportadora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 3, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Área de almacenamiento polietileno', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 4, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de empacado', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 5, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso alamcenado temporal de leche UHT', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 6, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso alamcenado temporal de kavetas', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 7, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes ADIPACK', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 8, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Área de prueba sellado', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 9, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Mesa ADIPACK', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 10, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Residuos de leche ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 11, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensillos', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 12, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 13, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 14, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 15, 'T-PRO-RE-025' );
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 16, 'T-PRO-RE-025');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 17, 'T-PRO-RE-025');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 18, 'T-PRO-RE-025');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón del area', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 19, 'T-PRO-RE-025');

--Actividades T-PRO-RE-025
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('CIP Tubería leche cruda', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 20, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso debajo de silo  1 y 2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 21, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Exterior de Silo', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 22, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior de Silo', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 23, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tinas acero inoxidable ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 24, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso en el MRU', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 25, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Casilla del MRU', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 26, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso del area de recepción', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 27, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Gradas del area de recepción', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 28, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Limpieza Ingreso planta UHT', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 29, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensilios de acero inoxidable  ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 30, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes del area', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 31, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 32, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 33, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 34, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 35, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 36, 'T-PRO-RE-031');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 37, 'T-PRO-RE-031');

--Actividades T-PRO-RE-029--
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso debajo del tanque aseptico ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 38, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes área  tanque aseptico', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 39, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso de almacenamiento temporal de tachos  ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 40, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tina almacenamiento de leche (reproceso)', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 41, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 7', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 42, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 8', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 43, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 9', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 44, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tuberias', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 45, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Area mixer', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 46, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes tanques de almacenamiento leche ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 47, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de tanques ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 48, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso Flex', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 49, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso HOMO', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 50, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensillos', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 51, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 52, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 53, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 54, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 55, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 56, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 57, 'T-PRO-RE-029');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón del area', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 58, 'T-PRO-RE-029');

--Actividades T-PRO-RE-028--
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso  de área de la maquina', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 59, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso codificadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 60, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Pitilladora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 61, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Encartonadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 62, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de pitilladora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 63, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de encartonadora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 64, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Envases con producto en gabetas', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 65, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso almacenado temporal de pallets ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 66, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Área pruebas destructivas ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 67, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensillos', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 68, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 69, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 70, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 71, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 72, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 73, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 74, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón del area', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 75, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón 1', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 75, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón 2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 76, 'T-PRO-RE-028');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Basura', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 77, 'T-PRO-RE-028');

--actividades T-PRO-RE-027
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso  de area de la maquina ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 78, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso codificadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 79, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Pitilladora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 80, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Encartonadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 81, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de pitilladora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 82, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de encartonadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 83, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Envases con porducto en gabetas', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 84, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso almacenado temporal de pallets ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 85, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Área pruebas destructivas ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 86, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensillos', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 87, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 88, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 89, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 90, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 91, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 92, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 93, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón 1 ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 94, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón 2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 95, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Basura ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 96, 'T-PRO-RE-027');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso area de etiquetado', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 97, 'T-PRO-RE-027');

-- Actividades CC.R 04.35
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso  de area de la maquina ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 98, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Gradas', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 99, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Plataforma ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 100, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso codificadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 101, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de Elix', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 102, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de tapas', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 103, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso de almacenamiento temporal de carton (cajas)', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 104, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Encartonadora ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 105, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso area de encartonadora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 106, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso area de etiquetado', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 107, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso alamcenado temporal de pallets ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 108, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Área pruebas destructivas ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 109, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensillos', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 110, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 111, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 112, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 113, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 114, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 115, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 116, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Basura ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 117, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón principal', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 118, 'CC.R 04.35');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón de la parte del elix', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 119, 'CC.R 04.35');

--Actividades CC.R 04.10

INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso debajo del tanque aseptico ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 120, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes área  tanque aseptico', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 121, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso de almacenamiento temporal de tachos  ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 122, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tina almacenamiento de leche (reproceso)', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 123, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 3', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 124, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 4', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 125, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 5', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 126, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tanque 6', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 127, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tuberias', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 128, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes tanques de almacenamiento leche ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 129, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso área de tanques ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 130, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso Flex', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 131, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso HOMO', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 132, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Utensillos', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 133, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 134, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 135, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 136, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 137, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 138, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 139, 'CC.R 04.10');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Sifón del area', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 140, 'CC.R 04.10');

--Actividad T-PRO-RE-023
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('CIP pasteurizador', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 141, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso debajo del pasteurizador', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 142, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior del tanque 6 ', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 143, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Llaves de tanque 6', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 144, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior del tanque 5', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 145, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Llaves de tanque 5', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 146, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior del tanque 4', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 147, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Llaves de tanque 4', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 148, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior del tanque 3', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 149, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Llaves de tanque 3', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 150, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior del tanque 2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 151, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Llaves de tanque 2', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 152, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Interior del tanque 1', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 153, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Llaves de tanque 1', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 154, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Estructuara externa enfriador', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 155, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Descremadora', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 156, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Homogenizador', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 157, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Tablero de comando', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 158, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso debajo de los tanques', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 159, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes que rodean el pasteurizador', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 160, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Paredes que rodean los tanques', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 161, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Piso y paredes que rodean el enfriador', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 162, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Escobas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 163, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Jabón en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 164, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Viledas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 165, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Manguera en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 166, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Documentos en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 167, 'T-PRO-RE-023');
INSERT INTO [Prod].[LimpFormularioActividad] ([Decsripcion], [CodEmpresa], [CreadoPor], [FechaHoraCreacion], [ActualixzadoPor], [FechaHoraActualizacion], [CodRegistro], [CodFormulario])
VALUES ('Herramientas en su lugar', 'PQSA', 'ngmolina', GETDATE(), 'ngmolina', GETDATE(), 168, 'T-PRO-RE-023');


select * from Prod.LimpRegistro
select * from Prod.LimpFormulario
select * from Prod.LimpArea
select * from Prod.LimpFormularioActividad
select * from Prod.LimpRegistroDetalle