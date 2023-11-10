USE [msdb]
GO

/****** Object:  Job [vaux_end_auction]    Script Date: 10/31/2023 9:21:11 PM ******/
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [[Uncategorized (Local)]]    Script Date: 10/31/2023 9:21:11 PM ******/
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=N'vaux_end_auction', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'No description available.', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'HaiPKH', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [update_item_status_8]    Script Date: 10/31/2023 9:21:11 PM ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'update_item_status_8', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'UPDATE i
    SET [Status] = 8
  FROM [dbo].[Items] as i
  INNER JOIN [dbo].[AuctionSessionItem] as auci
    ON i.[Id] = auci.[ItemId]
  INNER JOIN [dbo].[AuctionSessions] as auc
    ON auc.[Id] = auci.[AuctionSessionId]
  INNER JOIN 
    (SELECT [ItemId], MAX([Amount]) Amount 
      FROM [dbo].[Bids] 
      GROUP BY [ItemId]) as b
    ON b.[ItemId] = i.[Id]
  WHERE i.[Status] = 4 AND 
    convert(varchar(10), [StartDate], 102) = convert(varchar(10), getdate(), 102) AND 
    auc.[Deleted] IS NULL AND
    b.Amount >= i.[ReservePrice]', 
		@database_name=N'Vaux', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [update_item_status_7]    Script Date: 10/31/2023 9:21:11 PM ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'update_item_status_7', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'UPDATE i
    SET [Status] = 7
  FROM [dbo].[Items] as i
  INNER JOIN [dbo].[AuctionSessionItem] as auci
    ON i.[Id] = auci.[ItemId]
  INNER JOIN [dbo].[AuctionSessions] as auc
    ON auc.[Id] = auci.[AuctionSessionId]
  WHERE i.[Status] = 4 AND 
    convert(varchar(10), [StartDate], 102) = convert(varchar(10), getdate(), 102) AND 
    auc.[Deleted] IS NULL', 
		@database_name=N'Vaux', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'daily_evening', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=0, 
		@active_start_date=20231031, 
		@active_end_date=99991231, 
		@active_start_time=190000, 
		@active_end_time=235959, 
		@schedule_uid=N'ce9b07dc-c770-4adb-b607-0a4412a93204'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:
GO


