
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2013 14:06:06
-- Generated from EDMX file: E:\TradePlatform.NET\TradePlatform.MT4\TradePlatform.MT4.Data\TradePlatformModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ApplicationDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BankAccount_BankAccountGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankAccounts] DROP CONSTRAINT [FK_BankAccount_BankAccountGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_BankAccount_BankTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankTransactions] DROP CONSTRAINT [FK_BankAccount_BankTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_BankTransactionCategory_BankTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankTransactions] DROP CONSTRAINT [FK_BankTransactionCategory_BankTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_BankTransactionCategoryBudget_BankTransactionCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankTransactionCategoryBudgets] DROP CONSTRAINT [FK_BankTransactionCategoryBudget_BankTransactionCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_BankTransactionCategoryBudgetP_BankTransactionCategoryBudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankTransactionCategoryBudgets] DROP CONSTRAINT [FK_BankTransactionCategoryBudgetP_BankTransactionCategoryBudget];
GO
IF OBJECT_ID(N'[dbo].[FK_BankTransactionCategoryGroup_BankTransactionCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BankTransactionCategories] DROP CONSTRAINT [FK_BankTransactionCategoryGroup_BankTransactionCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_ExpertSystem_MetaTraderAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExpertSystems] DROP CONSTRAINT [FK_ExpertSystem_MetaTraderAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_ExpertSystem_MetaTraderOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaTraderOrders] DROP CONSTRAINT [FK_ExpertSystem_MetaTraderOrder];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Me__Appli__276EDEB3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Membership] DROP CONSTRAINT [FK__aspnet_Me__Appli__276EDEB3];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Me__UserI__286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Membership] DROP CONSTRAINT [FK__aspnet_Me__UserI__286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Pr__UserI__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Profile] DROP CONSTRAINT [FK__aspnet_Pr__UserI__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Ro__Appli__45F365D3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Roles] DROP CONSTRAINT [FK__aspnet_Ro__Appli__45F365D3];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Us__Appli__173876EA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_Users] DROP CONSTRAINT [FK__aspnet_Us__Appli__173876EA];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Us__RoleI__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_UsersInRoles] DROP CONSTRAINT [FK__aspnet_Us__RoleI__4AB81AF0];
GO
IF OBJECT_ID(N'[dbo].[FK__aspnet_Us__UserI__49C3F6B7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aspnet_UsersInRoles] DROP CONSTRAINT [FK__aspnet_Us__UserI__49C3F6B7];
GO
IF OBJECT_ID(N'[dbo].[FK_MetaTraderOrder_MetaTraderAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaTraderOrders] DROP CONSTRAINT [FK_MetaTraderOrder_MetaTraderAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_MetaTraderTickData_MetaTraderAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MetaTraderTickDatas] DROP CONSTRAINT [FK_MetaTraderTickData_MetaTraderAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_MonthlyData_MetaTraderAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MonthlyDatas] DROP CONSTRAINT [FK_MonthlyData_MetaTraderAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_ScheduledTaskParameter_ScheduledTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScheduledTaskParameters] DROP CONSTRAINT [FK_ScheduledTaskParameter_ScheduledTask];
GO
IF OBJECT_ID(N'[dbo].[FK_TradeDuplicatorBee_MetaTraderAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TradeDuplicatorBees] DROP CONSTRAINT [FK_TradeDuplicatorBee_MetaTraderAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_TradeDuplicatorBee_TradeDuplicatorDrone]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TradeDuplicatorDrones] DROP CONSTRAINT [FK_TradeDuplicatorBee_TradeDuplicatorDrone];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__RefactorLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__RefactorLog];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Applications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Applications];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Membership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Membership];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Profile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Profile];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Roles];
GO
IF OBJECT_ID(N'[dbo].[aspnet_SchemaVersions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_SchemaVersions];
GO
IF OBJECT_ID(N'[dbo].[aspnet_Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_Users];
GO
IF OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aspnet_UsersInRoles];
GO
IF OBJECT_ID(N'[dbo].[BankAccountGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankAccountGroups];
GO
IF OBJECT_ID(N'[dbo].[BankAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankAccounts];
GO
IF OBJECT_ID(N'[dbo].[BankTransactionCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankTransactionCategories];
GO
IF OBJECT_ID(N'[dbo].[BankTransactionCategoryBudgetPeriods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankTransactionCategoryBudgetPeriods];
GO
IF OBJECT_ID(N'[dbo].[BankTransactionCategoryBudgets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankTransactionCategoryBudgets];
GO
IF OBJECT_ID(N'[dbo].[BankTransactionCategoryGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankTransactionCategoryGroups];
GO
IF OBJECT_ID(N'[dbo].[BankTransactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankTransactions];
GO
IF OBJECT_ID(N'[dbo].[ExpertSystems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExpertSystems];
GO
IF OBJECT_ID(N'[dbo].[MetaTraderAccountFilterSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaTraderAccountFilterSets];
GO
IF OBJECT_ID(N'[dbo].[MetaTraderAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaTraderAccounts];
GO
IF OBJECT_ID(N'[dbo].[MetaTraderOrderFilterSets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaTraderOrderFilterSets];
GO
IF OBJECT_ID(N'[dbo].[MetaTraderOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaTraderOrders];
GO
IF OBJECT_ID(N'[dbo].[MetaTraderTickDatas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetaTraderTickDatas];
GO
IF OBJECT_ID(N'[dbo].[MonthlyDatas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MonthlyDatas];
GO
IF OBJECT_ID(N'[dbo].[RolePermissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolePermissions];
GO
IF OBJECT_ID(N'[dbo].[ScheduledTaskParameters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScheduledTaskParameters];
GO
IF OBJECT_ID(N'[dbo].[ScheduledTasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScheduledTasks];
GO
IF OBJECT_ID(N'[dbo].[TradeDuplicatorBees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TradeDuplicatorBees];
GO
IF OBJECT_ID(N'[dbo].[TradeDuplicatorDrones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TradeDuplicatorDrones];
GO
IF OBJECT_ID(N'[TradePlatformModelStoreContainer].[vw_aspnet_Applications]', 'U') IS NOT NULL
    DROP TABLE [TradePlatformModelStoreContainer].[vw_aspnet_Applications];
GO
IF OBJECT_ID(N'[TradePlatformModelStoreContainer].[vw_aspnet_MembershipUsers]', 'U') IS NOT NULL
    DROP TABLE [TradePlatformModelStoreContainer].[vw_aspnet_MembershipUsers];
GO
IF OBJECT_ID(N'[TradePlatformModelStoreContainer].[vw_aspnet_Profiles]', 'U') IS NOT NULL
    DROP TABLE [TradePlatformModelStoreContainer].[vw_aspnet_Profiles];
GO
IF OBJECT_ID(N'[TradePlatformModelStoreContainer].[vw_aspnet_Roles]', 'U') IS NOT NULL
    DROP TABLE [TradePlatformModelStoreContainer].[vw_aspnet_Roles];
GO
IF OBJECT_ID(N'[TradePlatformModelStoreContainer].[vw_aspnet_Users]', 'U') IS NOT NULL
    DROP TABLE [TradePlatformModelStoreContainer].[vw_aspnet_Users];
GO
IF OBJECT_ID(N'[TradePlatformModelStoreContainer].[vw_aspnet_UsersInRoles]', 'U') IS NOT NULL
    DROP TABLE [TradePlatformModelStoreContainer].[vw_aspnet_UsersInRoles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__RefactorLog'
CREATE TABLE [dbo].[C__RefactorLog] (
    [OperationKey] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'aspnet_Applications'
CREATE TABLE [dbo].[aspnet_Applications] (
    [ApplicationName] nvarchar(256)  NOT NULL,
    [LoweredApplicationName] nvarchar(256)  NOT NULL,
    [ApplicationId] uniqueidentifier  NOT NULL,
    [Description] nvarchar(256)  NULL
);
GO

-- Creating table 'aspnet_Membership'
CREATE TABLE [dbo].[aspnet_Membership] (
    [ApplicationId] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Password] nvarchar(128)  NOT NULL,
    [PasswordFormat] int  NOT NULL,
    [PasswordSalt] nvarchar(128)  NOT NULL,
    [MobilePIN] nvarchar(16)  NULL,
    [Email] nvarchar(256)  NULL,
    [LoweredEmail] nvarchar(256)  NULL,
    [PasswordQuestion] nvarchar(256)  NULL,
    [PasswordAnswer] nvarchar(128)  NULL,
    [IsApproved] bit  NOT NULL,
    [IsLockedOut] bit  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [LastLoginDate] datetime  NOT NULL,
    [LastPasswordChangedDate] datetime  NOT NULL,
    [LastLockoutDate] datetime  NOT NULL,
    [FailedPasswordAttemptCount] int  NOT NULL,
    [FailedPasswordAttemptWindowStart] datetime  NOT NULL,
    [FailedPasswordAnswerAttemptCount] int  NOT NULL,
    [FailedPasswordAnswerAttemptWindowStart] datetime  NOT NULL,
    [Comment] nvarchar(max)  NULL
);
GO

-- Creating table 'aspnet_Profile'
CREATE TABLE [dbo].[aspnet_Profile] (
    [UserId] uniqueidentifier  NOT NULL,
    [PropertyNames] nvarchar(max)  NOT NULL,
    [PropertyValuesString] nvarchar(max)  NOT NULL,
    [PropertyValuesBinary] varbinary(max)  NOT NULL,
    [LastUpdatedDate] datetime  NOT NULL
);
GO

-- Creating table 'aspnet_Roles'
CREATE TABLE [dbo].[aspnet_Roles] (
    [ApplicationId] uniqueidentifier  NOT NULL,
    [RoleId] uniqueidentifier  NOT NULL,
    [RoleName] nvarchar(256)  NOT NULL,
    [LoweredRoleName] nvarchar(256)  NOT NULL,
    [Description] nvarchar(256)  NULL
);
GO

-- Creating table 'aspnet_SchemaVersions'
CREATE TABLE [dbo].[aspnet_SchemaVersions] (
    [Feature] nvarchar(128)  NOT NULL,
    [CompatibleSchemaVersion] nvarchar(128)  NOT NULL,
    [IsCurrentVersion] bit  NOT NULL
);
GO

-- Creating table 'aspnet_Users'
CREATE TABLE [dbo].[aspnet_Users] (
    [ApplicationId] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [LoweredUserName] nvarchar(256)  NOT NULL,
    [MobileAlias] nvarchar(16)  NULL,
    [IsAnonymous] bit  NOT NULL,
    [LastActivityDate] datetime  NOT NULL
);
GO

-- Creating table 'BankAccountGroups'
CREATE TABLE [dbo].[BankAccountGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'BankAccounts'
CREATE TABLE [dbo].[BankAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Number] nvarchar(255)  NOT NULL,
    [Abbr] nvarchar(255)  NOT NULL,
    [InitionalDeposit] decimal(18,2)  NOT NULL,
    [BankAccount_BankAccountGroup] int  NULL
);
GO

-- Creating table 'BankTransactionCategories'
CREATE TABLE [dbo].[BankTransactionCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [HasBudget] bit  NOT NULL,
    [BankTransactionCategoryGroup_BankTransactionCategory] int  NOT NULL
);
GO

-- Creating table 'BankTransactionCategoryBudgetPeriods'
CREATE TABLE [dbo].[BankTransactionCategoryBudgetPeriods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [BudgetPeriodStart] datetime  NOT NULL,
    [BudgetPeriodEnd] datetime  NOT NULL,
    [Comment] nvarchar(255)  NULL
);
GO

-- Creating table 'BankTransactionCategoryBudgets'
CREATE TABLE [dbo].[BankTransactionCategoryBudgets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [PeriodLimit] decimal(18,2)  NOT NULL,
    [BankTransactionCategoryBudget_BankTransactionCategory] int  NOT NULL,
    [BankTransactionCategoryBudgetP_BankTransactionCategoryBudget] int  NOT NULL
);
GO

-- Creating table 'BankTransactionCategoryGroups'
CREATE TABLE [dbo].[BankTransactionCategoryGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'BankTransactions'
CREATE TABLE [dbo].[BankTransactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Payee] nvarchar(255)  NULL,
    [TransactionDate] datetime  NOT NULL,
    [Comment] nvarchar(255)  NULL,
    [Ammount] decimal(18,2)  NOT NULL,
    [TransactionUniqueId] nvarchar(255)  NOT NULL,
    [BankAccount_BankTransaction] int  NOT NULL,
    [BankTransactionCategory_BankTransaction] int  NOT NULL
);
GO

-- Creating table 'ExpertSystems'
CREATE TABLE [dbo].[ExpertSystems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [SystemVersion] nvarchar(255)  NULL,
    [ExpertVersion] nvarchar(255)  NULL,
    [ExpertName] nvarchar(255)  NULL,
    [ExpertAllowAddones] bit  NULL,
    [ModuleTacticsAutoEven] bit  NULL,
    [ModuleTacticsAutoEvenAll] bit  NULL,
    [ModuleTacticsAutoEvenBars] int  NULL,
    [ModuleTacticsAutoEvenPips] int  NULL,
    [ModuleTacticsEvenStop] int  NULL,
    [ModuleTacticsAutoTrail] bit  NULL,
    [ModuleTacticsAutoTrailAll] bit  NULL,
    [ModuleTacticsAutoTrailBars] int  NULL,
    [ModuleTacticsAutoTrailPips] int  NULL,
    [ModuleTacticsTrailStop] int  NULL,
    [ModuleTacticsAutoLockLoss] bit  NULL,
    [ModuleTacticsAutoLockLossAll] bit  NULL,
    [ModuleTacticsAutoLockLossPips] int  NULL,
    [ModuleTacticsLockLossRatio] float  NULL,
    [ModuleTacticsLockLossStop] int  NULL,
    [ModuleTacticsAutoLock] bit  NULL,
    [ModuleTacticsAutoLockAll] bit  NULL,
    [ModuleTacticsAutoLockPips] int  NULL,
    [ModuleTacticsLockStop] int  NULL,
    [ModuleTacticsRelock] bit  NULL,
    [ModuleTacticsPartialLockRatio] float  NULL,
    [ModuleTacticsAutoMartin] bit  NULL,
    [ModuleTacticsMartinExponent] float  NULL,
    [ModuleTacticsMartinKnees] int  NULL,
    [ModuleTacticsAutoBalance] bit  NULL,
    [ModuleTacticsBalancePips] int  NULL,
    [ModuleTacticsHalfTake] bit  NULL,
    [ModuleTacticsHalfTakeTake] int  NULL,
    [ModuleTacticsHalfTakeStop] int  NULL,
    [ModuleTacticsSmartStop] bit  NULL,
    [ModuleTacticsSmartStopPips] int  NULL,
    [ModuleTacticsSmartStopBars] int  NULL,
    [ModuleTacticsSmartStopBreak] int  NULL,
    [ModuleTacticsDispersPips] int  NULL,
    [ModuleTacticsDispersBars] int  NULL,
    [ModuleTacticsVolatile] int  NULL,
    [ModuleTraderUseStrategy] bit  NULL,
    [ModuleTraderUseTrendFilter] bit  NULL,
    [ModuleTraderUsePositionLock] bit  NULL,
    [ModuleTraderHoursStart] int  NULL,
    [ModuleTraderHoursEnd] int  NULL,
    [ModuleTraderLossInARow] int  NULL,
    [ModuleTraderEquityLimit] int  NULL,
    [ModuleTraderOnlyInZones] bit  NULL,
    [ModuleTraderTakeInZones] bit  NULL,
    [AdnVisualTraderIsActive] bit  NULL,
    [AdnVisualTraderOrderComment] nvarchar(255)  NULL,
    [ModuleMMStopLoss] int  NULL,
    [ModuleMMTakeProfit] int  NULL,
    [ModuleMMMinMarginLevel] int  NULL,
    [ModuleMMMaxOpenOrders] int  NULL,
    [ModuleMMMaxSpread] int  NULL,
    [ModuleMMRiskFactor] float  NULL,
    [ModuleMMUseFixedLot] bit  NULL,
    [ModuleMMFixedLot] float  NULL,
    [ExtOperatorUseDefaultPoint] bit  NULL,
    [ExtOperatorPoint] float  NULL,
    [ExtOperatorMagicNumber] int  NULL,
    [ExtOperatorAutoMagic] bit  NULL,
    [ExtOperatorRequoteTimes] int  NULL,
    [ExtOperatorRequoteSleep] int  NULL,
    [ExtOperatorSlippage] int  NULL,
    [ExtOperatorStealthMode] bit  NULL,
    [ExtOperatorSetStopAfter] bit  NULL,
    [SignalIndicatorsEMASlow] int  NULL,
    [SignalIndicatorsEMAFast] int  NULL,
    [SignalIndicatorsRSIPeriod] int  NULL,
    [SignalIndicatorsRSIUpper] int  NULL,
    [SignalIndicatorsRSILower] int  NULL,
    [SignalPASlippage] int  NULL,
    [AdnStealthUseBestPrice] bit  NULL,
    [ExtTimeTRM] int  NULL,
    [AdnReportingIsActive] bit  NULL,
    [AdnLevelsIsActive] bit  NULL,
    [AdnDiagnosticsUseDebug] bit  NULL,
    [AdnDiagnosticsUseTrace] bit  NULL,
    [AdnDiagnosticsUseLog] bit  NULL,
    [AdnDiagnosticsUseNotify] bit  NULL,
    [AdnDiagnosticsShowOrders] bit  NULL,
    [AdnDiagnosticsShowInfo] bit  NULL,
    [BridgeNETIsActive] bit  NULL,
    [BridgeNETServer] nvarchar(255)  NULL,
    [BridgeNETPort] int  NULL,
    [WorkingSymbol] nvarchar(255)  NULL,
    [WorkingPeriod] int  NULL,
    [State] nvarchar(255)  NOT NULL,
    [LastActivity] datetime  NOT NULL,
    [LastExecutionError] nvarchar(255)  NULL,
    [ExpertSystem_MetaTraderAccount] int  NOT NULL
);
GO

-- Creating table 'MetaTraderAccountFilterSets'
CREATE TABLE [dbo].[MetaTraderAccountFilterSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [IsDemo] bit  NULL,
    [IsTesting] bit  NULL,
    [IsOptimization] bit  NULL,
    [AccountName] nvarchar(255)  NULL,
    [AccountNumber] int  NULL,
    [AccountCompany] nvarchar(255)  NULL
);
GO

-- Creating table 'MetaTraderAccounts'
CREATE TABLE [dbo].[MetaTraderAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [AccountBalance] decimal(18,2)  NOT NULL,
    [AccountCredit] float  NOT NULL,
    [AccountCompany] nvarchar(255)  NOT NULL,
    [AccountCurrency] nvarchar(255)  NOT NULL,
    [AccountEquity] decimal(18,2)  NOT NULL,
    [AccountFreeMargin] decimal(18,2)  NOT NULL,
    [AccountFreeMarginMode] float  NOT NULL,
    [AccountLeverage] int  NOT NULL,
    [AccountMargin] decimal(18,2)  NOT NULL,
    [AccountName] nvarchar(255)  NOT NULL,
    [AccountNumber] int  NOT NULL,
    [AccountProfit] decimal(18,2)  NOT NULL,
    [AccountServer] nvarchar(255)  NOT NULL,
    [AccountStopoutLevel] int  NOT NULL,
    [AccountStopoutMode] int  NOT NULL,
    [IsDemo] bit  NOT NULL,
    [IsTesting] bit  NOT NULL,
    [IsOptimization] bit  NOT NULL,
    [IsExpertEnabled] bit  NOT NULL,
    [DrawDown] decimal(18,9)  NULL
);
GO

-- Creating table 'MetaTraderOrderFilterSets'
CREATE TABLE [dbo].[MetaTraderOrderFilterSets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [CloseTimeFrom] datetime  NULL,
    [CloseTimeTo] datetime  NULL,
    [OpenTimeFrom] datetime  NULL,
    [OpenTimeTo] datetime  NULL,
    [CommentContains] nvarchar(255)  NULL,
    [CommentNotContains] nvarchar(255)  NULL,
    [Symbol] nvarchar(255)  NULL,
    [MagicNumber] int  NULL,
    [Type] nvarchar(255)  NULL,
    [IsClosed] bit  NULL
);
GO

-- Creating table 'MetaTraderOrders'
CREATE TABLE [dbo].[MetaTraderOrders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Ticket] int  NOT NULL,
    [Comment] nvarchar(255)  NULL,
    [OpenTime] datetime  NOT NULL,
    [CloseTime] datetime  NOT NULL,
    [OpenPrice] float  NOT NULL,
    [ClosePrice] float  NOT NULL,
    [StopLoss] float  NOT NULL,
    [TakeProfit] float  NOT NULL,
    [Type] nvarchar(255)  NOT NULL,
    [Size] float  NOT NULL,
    [Symbol] nvarchar(255)  NOT NULL,
    [Swap] decimal(18,2)  NOT NULL,
    [Profit] decimal(18,2)  NOT NULL,
    [MagicNumber] int  NOT NULL,
    [Commission] decimal(18,2)  NOT NULL,
    [IsClosed] bit  NOT NULL,
    [MetaTraderOrder_MetaTraderAccount] int  NOT NULL,
    [ExpertSystem_MetaTraderOrder] int  NULL
);
GO

-- Creating table 'MetaTraderTickDatas'
CREATE TABLE [dbo].[MetaTraderTickDatas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Bid] float  NOT NULL,
    [Ask] float  NOT NULL,
    [TickDate] datetime  NOT NULL,
    [Equity] decimal(18,2)  NOT NULL,
    [MetaTraderTickData_MetaTraderAccount] int  NOT NULL
);
GO

-- Creating table 'MonthlyDatas'
CREATE TABLE [dbo].[MonthlyDatas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [MonthlyData_MetaTraderAccount] int  NOT NULL
);
GO

-- Creating table 'RolePermissions'
CREATE TABLE [dbo].[RolePermissions] (
    [RoleName] nvarchar(128)  NOT NULL,
    [PermissionId] nvarchar(322)  NOT NULL
);
GO

-- Creating table 'ScheduledTaskParameters'
CREATE TABLE [dbo].[ScheduledTaskParameters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Value] nvarchar(255)  NOT NULL,
    [ScheduledTaskParameter_ScheduledTask] int  NOT NULL
);
GO

-- Creating table 'ScheduledTasks'
CREATE TABLE [dbo].[ScheduledTasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Type] nvarchar(255)  NOT NULL,
    [Interval] int  NOT NULL,
    [Executions] int  NOT NULL,
    [IsActive] bit  NOT NULL,
    [State] nvarchar(255)  NOT NULL,
    [LastMessage] nvarchar(255)  NULL,
    [LastExecution] datetime  NULL,
    [LastError] nvarchar(255)  NULL
);
GO

-- Creating table 'TradeDuplicatorBees'
CREATE TABLE [dbo].[TradeDuplicatorBees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [TradeDuplicatorBee_MetaTraderAccount] int  NOT NULL
);
GO

-- Creating table 'TradeDuplicatorDrones'
CREATE TABLE [dbo].[TradeDuplicatorDrones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RowVersion] binary(8)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [LotRatio] float  NOT NULL,
    [Slippage] int  NOT NULL,
    [TradeDuplicatorBee_TradeDuplicatorDrone] int  NOT NULL
);
GO

-- Creating table 'vw_aspnet_Applications'
CREATE TABLE [dbo].[vw_aspnet_Applications] (
    [ApplicationName] nvarchar(256)  NOT NULL,
    [LoweredApplicationName] nvarchar(256)  NOT NULL,
    [ApplicationId] uniqueidentifier  NOT NULL,
    [Description] nvarchar(256)  NULL
);
GO

-- Creating table 'vw_aspnet_MembershipUsers'
CREATE TABLE [dbo].[vw_aspnet_MembershipUsers] (
    [UserId] uniqueidentifier  NOT NULL,
    [PasswordFormat] int  NOT NULL,
    [MobilePIN] nvarchar(16)  NULL,
    [Email] nvarchar(256)  NULL,
    [LoweredEmail] nvarchar(256)  NULL,
    [PasswordQuestion] nvarchar(256)  NULL,
    [PasswordAnswer] nvarchar(128)  NULL,
    [IsApproved] bit  NOT NULL,
    [IsLockedOut] bit  NOT NULL,
    [CreateDate] datetime  NOT NULL,
    [LastLoginDate] datetime  NOT NULL,
    [LastPasswordChangedDate] datetime  NOT NULL,
    [LastLockoutDate] datetime  NOT NULL,
    [FailedPasswordAttemptCount] int  NOT NULL,
    [FailedPasswordAttemptWindowStart] datetime  NOT NULL,
    [FailedPasswordAnswerAttemptCount] int  NOT NULL,
    [FailedPasswordAnswerAttemptWindowStart] datetime  NOT NULL,
    [Comment] nvarchar(max)  NULL,
    [ApplicationId] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [MobileAlias] nvarchar(16)  NULL,
    [IsAnonymous] bit  NOT NULL,
    [LastActivityDate] datetime  NOT NULL
);
GO

-- Creating table 'vw_aspnet_Profiles'
CREATE TABLE [dbo].[vw_aspnet_Profiles] (
    [UserId] uniqueidentifier  NOT NULL,
    [LastUpdatedDate] datetime  NOT NULL,
    [DataSize] int  NULL
);
GO

-- Creating table 'vw_aspnet_Roles'
CREATE TABLE [dbo].[vw_aspnet_Roles] (
    [ApplicationId] uniqueidentifier  NOT NULL,
    [RoleId] uniqueidentifier  NOT NULL,
    [RoleName] nvarchar(256)  NOT NULL,
    [LoweredRoleName] nvarchar(256)  NOT NULL,
    [Description] nvarchar(256)  NULL
);
GO

-- Creating table 'vw_aspnet_Users'
CREATE TABLE [dbo].[vw_aspnet_Users] (
    [ApplicationId] uniqueidentifier  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [LoweredUserName] nvarchar(256)  NOT NULL,
    [MobileAlias] nvarchar(16)  NULL,
    [IsAnonymous] bit  NOT NULL,
    [LastActivityDate] datetime  NOT NULL
);
GO

-- Creating table 'vw_aspnet_UsersInRoles'
CREATE TABLE [dbo].[vw_aspnet_UsersInRoles] (
    [UserId] uniqueidentifier  NOT NULL,
    [RoleId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'aspnet_UsersInRoles'
CREATE TABLE [dbo].[aspnet_UsersInRoles] (
    [aspnet_Roles_RoleId] uniqueidentifier  NOT NULL,
    [aspnet_Users_UserId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [OperationKey] in table 'C__RefactorLog'
ALTER TABLE [dbo].[C__RefactorLog]
ADD CONSTRAINT [PK_C__RefactorLog]
    PRIMARY KEY CLUSTERED ([OperationKey] ASC);
GO

-- Creating primary key on [ApplicationId] in table 'aspnet_Applications'
ALTER TABLE [dbo].[aspnet_Applications]
ADD CONSTRAINT [PK_aspnet_Applications]
    PRIMARY KEY CLUSTERED ([ApplicationId] ASC);
GO

-- Creating primary key on [UserId] in table 'aspnet_Membership'
ALTER TABLE [dbo].[aspnet_Membership]
ADD CONSTRAINT [PK_aspnet_Membership]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [UserId] in table 'aspnet_Profile'
ALTER TABLE [dbo].[aspnet_Profile]
ADD CONSTRAINT [PK_aspnet_Profile]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [RoleId] in table 'aspnet_Roles'
ALTER TABLE [dbo].[aspnet_Roles]
ADD CONSTRAINT [PK_aspnet_Roles]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [Feature], [CompatibleSchemaVersion] in table 'aspnet_SchemaVersions'
ALTER TABLE [dbo].[aspnet_SchemaVersions]
ADD CONSTRAINT [PK_aspnet_SchemaVersions]
    PRIMARY KEY CLUSTERED ([Feature], [CompatibleSchemaVersion] ASC);
GO

-- Creating primary key on [UserId] in table 'aspnet_Users'
ALTER TABLE [dbo].[aspnet_Users]
ADD CONSTRAINT [PK_aspnet_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Id] in table 'BankAccountGroups'
ALTER TABLE [dbo].[BankAccountGroups]
ADD CONSTRAINT [PK_BankAccountGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankAccounts'
ALTER TABLE [dbo].[BankAccounts]
ADD CONSTRAINT [PK_BankAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankTransactionCategories'
ALTER TABLE [dbo].[BankTransactionCategories]
ADD CONSTRAINT [PK_BankTransactionCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankTransactionCategoryBudgetPeriods'
ALTER TABLE [dbo].[BankTransactionCategoryBudgetPeriods]
ADD CONSTRAINT [PK_BankTransactionCategoryBudgetPeriods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankTransactionCategoryBudgets'
ALTER TABLE [dbo].[BankTransactionCategoryBudgets]
ADD CONSTRAINT [PK_BankTransactionCategoryBudgets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankTransactionCategoryGroups'
ALTER TABLE [dbo].[BankTransactionCategoryGroups]
ADD CONSTRAINT [PK_BankTransactionCategoryGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankTransactions'
ALTER TABLE [dbo].[BankTransactions]
ADD CONSTRAINT [PK_BankTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExpertSystems'
ALTER TABLE [dbo].[ExpertSystems]
ADD CONSTRAINT [PK_ExpertSystems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetaTraderAccountFilterSets'
ALTER TABLE [dbo].[MetaTraderAccountFilterSets]
ADD CONSTRAINT [PK_MetaTraderAccountFilterSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetaTraderAccounts'
ALTER TABLE [dbo].[MetaTraderAccounts]
ADD CONSTRAINT [PK_MetaTraderAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetaTraderOrderFilterSets'
ALTER TABLE [dbo].[MetaTraderOrderFilterSets]
ADD CONSTRAINT [PK_MetaTraderOrderFilterSets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetaTraderOrders'
ALTER TABLE [dbo].[MetaTraderOrders]
ADD CONSTRAINT [PK_MetaTraderOrders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetaTraderTickDatas'
ALTER TABLE [dbo].[MetaTraderTickDatas]
ADD CONSTRAINT [PK_MetaTraderTickDatas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MonthlyDatas'
ALTER TABLE [dbo].[MonthlyDatas]
ADD CONSTRAINT [PK_MonthlyDatas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [RoleName], [PermissionId] in table 'RolePermissions'
ALTER TABLE [dbo].[RolePermissions]
ADD CONSTRAINT [PK_RolePermissions]
    PRIMARY KEY CLUSTERED ([RoleName], [PermissionId] ASC);
GO

-- Creating primary key on [Id] in table 'ScheduledTaskParameters'
ALTER TABLE [dbo].[ScheduledTaskParameters]
ADD CONSTRAINT [PK_ScheduledTaskParameters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScheduledTasks'
ALTER TABLE [dbo].[ScheduledTasks]
ADD CONSTRAINT [PK_ScheduledTasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TradeDuplicatorBees'
ALTER TABLE [dbo].[TradeDuplicatorBees]
ADD CONSTRAINT [PK_TradeDuplicatorBees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TradeDuplicatorDrones'
ALTER TABLE [dbo].[TradeDuplicatorDrones]
ADD CONSTRAINT [PK_TradeDuplicatorDrones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ApplicationName], [LoweredApplicationName], [ApplicationId] in table 'vw_aspnet_Applications'
ALTER TABLE [dbo].[vw_aspnet_Applications]
ADD CONSTRAINT [PK_vw_aspnet_Applications]
    PRIMARY KEY CLUSTERED ([ApplicationName], [LoweredApplicationName], [ApplicationId] ASC);
GO

-- Creating primary key on [UserId], [PasswordFormat], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [ApplicationId], [UserName], [IsAnonymous], [LastActivityDate] in table 'vw_aspnet_MembershipUsers'
ALTER TABLE [dbo].[vw_aspnet_MembershipUsers]
ADD CONSTRAINT [PK_vw_aspnet_MembershipUsers]
    PRIMARY KEY CLUSTERED ([UserId], [PasswordFormat], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [ApplicationId], [UserName], [IsAnonymous], [LastActivityDate] ASC);
GO

-- Creating primary key on [UserId], [LastUpdatedDate] in table 'vw_aspnet_Profiles'
ALTER TABLE [dbo].[vw_aspnet_Profiles]
ADD CONSTRAINT [PK_vw_aspnet_Profiles]
    PRIMARY KEY CLUSTERED ([UserId], [LastUpdatedDate] ASC);
GO

-- Creating primary key on [ApplicationId], [RoleId], [RoleName], [LoweredRoleName] in table 'vw_aspnet_Roles'
ALTER TABLE [dbo].[vw_aspnet_Roles]
ADD CONSTRAINT [PK_vw_aspnet_Roles]
    PRIMARY KEY CLUSTERED ([ApplicationId], [RoleId], [RoleName], [LoweredRoleName] ASC);
GO

-- Creating primary key on [ApplicationId], [UserId], [UserName], [LoweredUserName], [IsAnonymous], [LastActivityDate] in table 'vw_aspnet_Users'
ALTER TABLE [dbo].[vw_aspnet_Users]
ADD CONSTRAINT [PK_vw_aspnet_Users]
    PRIMARY KEY CLUSTERED ([ApplicationId], [UserId], [UserName], [LoweredUserName], [IsAnonymous], [LastActivityDate] ASC);
GO

-- Creating primary key on [UserId], [RoleId] in table 'vw_aspnet_UsersInRoles'
ALTER TABLE [dbo].[vw_aspnet_UsersInRoles]
ADD CONSTRAINT [PK_vw_aspnet_UsersInRoles]
    PRIMARY KEY CLUSTERED ([UserId], [RoleId] ASC);
GO

-- Creating primary key on [aspnet_Roles_RoleId], [aspnet_Users_UserId] in table 'aspnet_UsersInRoles'
ALTER TABLE [dbo].[aspnet_UsersInRoles]
ADD CONSTRAINT [PK_aspnet_UsersInRoles]
    PRIMARY KEY NONCLUSTERED ([aspnet_Roles_RoleId], [aspnet_Users_UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ApplicationId] in table 'aspnet_Membership'
ALTER TABLE [dbo].[aspnet_Membership]
ADD CONSTRAINT [FK__aspnet_Me__Appli__276EDEB3]
    FOREIGN KEY ([ApplicationId])
    REFERENCES [dbo].[aspnet_Applications]
        ([ApplicationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__aspnet_Me__Appli__276EDEB3'
CREATE INDEX [IX_FK__aspnet_Me__Appli__276EDEB3]
ON [dbo].[aspnet_Membership]
    ([ApplicationId]);
GO

-- Creating foreign key on [ApplicationId] in table 'aspnet_Roles'
ALTER TABLE [dbo].[aspnet_Roles]
ADD CONSTRAINT [FK__aspnet_Ro__Appli__45F365D3]
    FOREIGN KEY ([ApplicationId])
    REFERENCES [dbo].[aspnet_Applications]
        ([ApplicationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__aspnet_Ro__Appli__45F365D3'
CREATE INDEX [IX_FK__aspnet_Ro__Appli__45F365D3]
ON [dbo].[aspnet_Roles]
    ([ApplicationId]);
GO

-- Creating foreign key on [ApplicationId] in table 'aspnet_Users'
ALTER TABLE [dbo].[aspnet_Users]
ADD CONSTRAINT [FK__aspnet_Us__Appli__173876EA]
    FOREIGN KEY ([ApplicationId])
    REFERENCES [dbo].[aspnet_Applications]
        ([ApplicationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__aspnet_Us__Appli__173876EA'
CREATE INDEX [IX_FK__aspnet_Us__Appli__173876EA]
ON [dbo].[aspnet_Users]
    ([ApplicationId]);
GO

-- Creating foreign key on [UserId] in table 'aspnet_Membership'
ALTER TABLE [dbo].[aspnet_Membership]
ADD CONSTRAINT [FK__aspnet_Me__UserI__286302EC]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UserId] in table 'aspnet_Profile'
ALTER TABLE [dbo].[aspnet_Profile]
ADD CONSTRAINT [FK__aspnet_Pr__UserI__3C69FB99]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[aspnet_Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BankAccount_BankAccountGroup] in table 'BankAccounts'
ALTER TABLE [dbo].[BankAccounts]
ADD CONSTRAINT [FK_BankAccount_BankAccountGroup]
    FOREIGN KEY ([BankAccount_BankAccountGroup])
    REFERENCES [dbo].[BankAccountGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankAccount_BankAccountGroup'
CREATE INDEX [IX_FK_BankAccount_BankAccountGroup]
ON [dbo].[BankAccounts]
    ([BankAccount_BankAccountGroup]);
GO

-- Creating foreign key on [BankAccount_BankTransaction] in table 'BankTransactions'
ALTER TABLE [dbo].[BankTransactions]
ADD CONSTRAINT [FK_BankAccount_BankTransaction]
    FOREIGN KEY ([BankAccount_BankTransaction])
    REFERENCES [dbo].[BankAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankAccount_BankTransaction'
CREATE INDEX [IX_FK_BankAccount_BankTransaction]
ON [dbo].[BankTransactions]
    ([BankAccount_BankTransaction]);
GO

-- Creating foreign key on [BankTransactionCategory_BankTransaction] in table 'BankTransactions'
ALTER TABLE [dbo].[BankTransactions]
ADD CONSTRAINT [FK_BankTransactionCategory_BankTransaction]
    FOREIGN KEY ([BankTransactionCategory_BankTransaction])
    REFERENCES [dbo].[BankTransactionCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankTransactionCategory_BankTransaction'
CREATE INDEX [IX_FK_BankTransactionCategory_BankTransaction]
ON [dbo].[BankTransactions]
    ([BankTransactionCategory_BankTransaction]);
GO

-- Creating foreign key on [BankTransactionCategoryBudget_BankTransactionCategory] in table 'BankTransactionCategoryBudgets'
ALTER TABLE [dbo].[BankTransactionCategoryBudgets]
ADD CONSTRAINT [FK_BankTransactionCategoryBudget_BankTransactionCategory]
    FOREIGN KEY ([BankTransactionCategoryBudget_BankTransactionCategory])
    REFERENCES [dbo].[BankTransactionCategories]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankTransactionCategoryBudget_BankTransactionCategory'
CREATE INDEX [IX_FK_BankTransactionCategoryBudget_BankTransactionCategory]
ON [dbo].[BankTransactionCategoryBudgets]
    ([BankTransactionCategoryBudget_BankTransactionCategory]);
GO

-- Creating foreign key on [BankTransactionCategoryGroup_BankTransactionCategory] in table 'BankTransactionCategories'
ALTER TABLE [dbo].[BankTransactionCategories]
ADD CONSTRAINT [FK_BankTransactionCategoryGroup_BankTransactionCategory]
    FOREIGN KEY ([BankTransactionCategoryGroup_BankTransactionCategory])
    REFERENCES [dbo].[BankTransactionCategoryGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankTransactionCategoryGroup_BankTransactionCategory'
CREATE INDEX [IX_FK_BankTransactionCategoryGroup_BankTransactionCategory]
ON [dbo].[BankTransactionCategories]
    ([BankTransactionCategoryGroup_BankTransactionCategory]);
GO

-- Creating foreign key on [BankTransactionCategoryBudgetP_BankTransactionCategoryBudget] in table 'BankTransactionCategoryBudgets'
ALTER TABLE [dbo].[BankTransactionCategoryBudgets]
ADD CONSTRAINT [FK_BankTransactionCategoryBudgetP_BankTransactionCategoryBudget]
    FOREIGN KEY ([BankTransactionCategoryBudgetP_BankTransactionCategoryBudget])
    REFERENCES [dbo].[BankTransactionCategoryBudgetPeriods]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankTransactionCategoryBudgetP_BankTransactionCategoryBudget'
CREATE INDEX [IX_FK_BankTransactionCategoryBudgetP_BankTransactionCategoryBudget]
ON [dbo].[BankTransactionCategoryBudgets]
    ([BankTransactionCategoryBudgetP_BankTransactionCategoryBudget]);
GO

-- Creating foreign key on [ExpertSystem_MetaTraderAccount] in table 'ExpertSystems'
ALTER TABLE [dbo].[ExpertSystems]
ADD CONSTRAINT [FK_ExpertSystem_MetaTraderAccount]
    FOREIGN KEY ([ExpertSystem_MetaTraderAccount])
    REFERENCES [dbo].[MetaTraderAccounts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpertSystem_MetaTraderAccount'
CREATE INDEX [IX_FK_ExpertSystem_MetaTraderAccount]
ON [dbo].[ExpertSystems]
    ([ExpertSystem_MetaTraderAccount]);
GO

-- Creating foreign key on [ExpertSystem_MetaTraderOrder] in table 'MetaTraderOrders'
ALTER TABLE [dbo].[MetaTraderOrders]
ADD CONSTRAINT [FK_ExpertSystem_MetaTraderOrder]
    FOREIGN KEY ([ExpertSystem_MetaTraderOrder])
    REFERENCES [dbo].[ExpertSystems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpertSystem_MetaTraderOrder'
CREATE INDEX [IX_FK_ExpertSystem_MetaTraderOrder]
ON [dbo].[MetaTraderOrders]
    ([ExpertSystem_MetaTraderOrder]);
GO

-- Creating foreign key on [MetaTraderOrder_MetaTraderAccount] in table 'MetaTraderOrders'
ALTER TABLE [dbo].[MetaTraderOrders]
ADD CONSTRAINT [FK_MetaTraderOrder_MetaTraderAccount]
    FOREIGN KEY ([MetaTraderOrder_MetaTraderAccount])
    REFERENCES [dbo].[MetaTraderAccounts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MetaTraderOrder_MetaTraderAccount'
CREATE INDEX [IX_FK_MetaTraderOrder_MetaTraderAccount]
ON [dbo].[MetaTraderOrders]
    ([MetaTraderOrder_MetaTraderAccount]);
GO

-- Creating foreign key on [MetaTraderTickData_MetaTraderAccount] in table 'MetaTraderTickDatas'
ALTER TABLE [dbo].[MetaTraderTickDatas]
ADD CONSTRAINT [FK_MetaTraderTickData_MetaTraderAccount]
    FOREIGN KEY ([MetaTraderTickData_MetaTraderAccount])
    REFERENCES [dbo].[MetaTraderAccounts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MetaTraderTickData_MetaTraderAccount'
CREATE INDEX [IX_FK_MetaTraderTickData_MetaTraderAccount]
ON [dbo].[MetaTraderTickDatas]
    ([MetaTraderTickData_MetaTraderAccount]);
GO

-- Creating foreign key on [MonthlyData_MetaTraderAccount] in table 'MonthlyDatas'
ALTER TABLE [dbo].[MonthlyDatas]
ADD CONSTRAINT [FK_MonthlyData_MetaTraderAccount]
    FOREIGN KEY ([MonthlyData_MetaTraderAccount])
    REFERENCES [dbo].[MetaTraderAccounts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MonthlyData_MetaTraderAccount'
CREATE INDEX [IX_FK_MonthlyData_MetaTraderAccount]
ON [dbo].[MonthlyDatas]
    ([MonthlyData_MetaTraderAccount]);
GO

-- Creating foreign key on [TradeDuplicatorBee_MetaTraderAccount] in table 'TradeDuplicatorBees'
ALTER TABLE [dbo].[TradeDuplicatorBees]
ADD CONSTRAINT [FK_TradeDuplicatorBee_MetaTraderAccount]
    FOREIGN KEY ([TradeDuplicatorBee_MetaTraderAccount])
    REFERENCES [dbo].[MetaTraderAccounts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TradeDuplicatorBee_MetaTraderAccount'
CREATE INDEX [IX_FK_TradeDuplicatorBee_MetaTraderAccount]
ON [dbo].[TradeDuplicatorBees]
    ([TradeDuplicatorBee_MetaTraderAccount]);
GO

-- Creating foreign key on [ScheduledTaskParameter_ScheduledTask] in table 'ScheduledTaskParameters'
ALTER TABLE [dbo].[ScheduledTaskParameters]
ADD CONSTRAINT [FK_ScheduledTaskParameter_ScheduledTask]
    FOREIGN KEY ([ScheduledTaskParameter_ScheduledTask])
    REFERENCES [dbo].[ScheduledTasks]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScheduledTaskParameter_ScheduledTask'
CREATE INDEX [IX_FK_ScheduledTaskParameter_ScheduledTask]
ON [dbo].[ScheduledTaskParameters]
    ([ScheduledTaskParameter_ScheduledTask]);
GO

-- Creating foreign key on [TradeDuplicatorBee_TradeDuplicatorDrone] in table 'TradeDuplicatorDrones'
ALTER TABLE [dbo].[TradeDuplicatorDrones]
ADD CONSTRAINT [FK_TradeDuplicatorBee_TradeDuplicatorDrone]
    FOREIGN KEY ([TradeDuplicatorBee_TradeDuplicatorDrone])
    REFERENCES [dbo].[TradeDuplicatorBees]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TradeDuplicatorBee_TradeDuplicatorDrone'
CREATE INDEX [IX_FK_TradeDuplicatorBee_TradeDuplicatorDrone]
ON [dbo].[TradeDuplicatorDrones]
    ([TradeDuplicatorBee_TradeDuplicatorDrone]);
GO

-- Creating foreign key on [aspnet_Roles_RoleId] in table 'aspnet_UsersInRoles'
ALTER TABLE [dbo].[aspnet_UsersInRoles]
ADD CONSTRAINT [FK_aspnet_UsersInRoles_aspnet_Roles]
    FOREIGN KEY ([aspnet_Roles_RoleId])
    REFERENCES [dbo].[aspnet_Roles]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [aspnet_Users_UserId] in table 'aspnet_UsersInRoles'
ALTER TABLE [dbo].[aspnet_UsersInRoles]
ADD CONSTRAINT [FK_aspnet_UsersInRoles_aspnet_Users]
    FOREIGN KEY ([aspnet_Users_UserId])
    REFERENCES [dbo].[aspnet_Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_aspnet_UsersInRoles_aspnet_Users'
CREATE INDEX [IX_FK_aspnet_UsersInRoles_aspnet_Users]
ON [dbo].[aspnet_UsersInRoles]
    ([aspnet_Users_UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------