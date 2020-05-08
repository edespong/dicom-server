//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Health.Dicom.SqlServer.Features.Schema.Model
{
    using Microsoft.Health.SqlServer.Features.Client;
    using Microsoft.Health.SqlServer.Features.Schema.Model;

    internal class VLatest
    {
        internal readonly static ChangeFeedTable ChangeFeed = new ChangeFeedTable();
        internal readonly static DeletedInstanceTable DeletedInstance = new DeletedInstanceTable();
        internal readonly static InstanceTable Instance = new InstanceTable();
        internal readonly static SchemaVersionTable SchemaVersion = new SchemaVersionTable();
        internal readonly static SeriesMetadataCoreTable SeriesMetadataCore = new SeriesMetadataCoreTable();
        internal readonly static StudyMetadataCoreTable StudyMetadataCore = new StudyMetadataCoreTable();
        internal readonly static AddInstanceProcedure AddInstance = new AddInstanceProcedure();
        internal readonly static DeleteDeletedInstanceProcedure DeleteDeletedInstance = new DeleteDeletedInstanceProcedure();
        internal readonly static DeleteInstanceProcedure DeleteInstance = new DeleteInstanceProcedure();
        internal readonly static GetChangeFeedProcedure GetChangeFeed = new GetChangeFeedProcedure();
        internal readonly static GetChangeFeedLatestProcedure GetChangeFeedLatest = new GetChangeFeedLatestProcedure();
        internal readonly static GetInstanceProcedure GetInstance = new GetInstanceProcedure();
        internal readonly static IncrementDeletedInstanceRetryProcedure IncrementDeletedInstanceRetry = new IncrementDeletedInstanceRetryProcedure();
        internal readonly static RetrieveDeletedInstanceProcedure RetrieveDeletedInstance = new RetrieveDeletedInstanceProcedure();
        internal readonly static SelectCurrentSchemaVersionProcedure SelectCurrentSchemaVersion = new SelectCurrentSchemaVersionProcedure();
        internal readonly static UpdateInstanceStatusProcedure UpdateInstanceStatus = new UpdateInstanceStatusProcedure();
        internal readonly static UpsertSchemaVersionProcedure UpsertSchemaVersion = new UpsertSchemaVersionProcedure();
        internal class ChangeFeedTable : Table
        {
            internal ChangeFeedTable(): base("dbo.ChangeFeed")
            {
            }

            internal readonly BigIntColumn Sequence = new BigIntColumn("Sequence");
            internal readonly DateTime2Column TimeStamp = new DateTime2Column("TimeStamp", 7);
            internal readonly TinyIntColumn Action = new TinyIntColumn("Action");
            internal readonly VarCharColumn StudyInstanceUid = new VarCharColumn("StudyInstanceUid", 64);
            internal readonly VarCharColumn SeriesInstanceUid = new VarCharColumn("SeriesInstanceUid", 64);
            internal readonly VarCharColumn SopInstanceUid = new VarCharColumn("SopInstanceUid", 64);
            internal readonly BigIntColumn OriginalWatermark = new BigIntColumn("OriginalWatermark");
            internal readonly NullableBigIntColumn CurrentWatermark = new NullableBigIntColumn("CurrentWatermark");
        }

        internal class DeletedInstanceTable : Table
        {
            internal DeletedInstanceTable(): base("dbo.DeletedInstance")
            {
            }

            internal readonly VarCharColumn StudyInstanceUid = new VarCharColumn("StudyInstanceUid", 64);
            internal readonly VarCharColumn SeriesInstanceUid = new VarCharColumn("SeriesInstanceUid", 64);
            internal readonly VarCharColumn SopInstanceUid = new VarCharColumn("SopInstanceUid", 64);
            internal readonly BigIntColumn Watermark = new BigIntColumn("Watermark");
            internal readonly DateTimeOffsetColumn DeletedDateTime = new DateTimeOffsetColumn("DeletedDateTime", 0);
            internal readonly IntColumn RetryCount = new IntColumn("RetryCount");
            internal readonly DateTimeOffsetColumn CleanupAfter = new DateTimeOffsetColumn("CleanupAfter", 0);
        }

        internal class InstanceTable : Table
        {
            internal InstanceTable(): base("dbo.Instance")
            {
            }

            internal readonly VarCharColumn StudyInstanceUid = new VarCharColumn("StudyInstanceUid", 64);
            internal readonly VarCharColumn SeriesInstanceUid = new VarCharColumn("SeriesInstanceUid", 64);
            internal readonly VarCharColumn SopInstanceUid = new VarCharColumn("SopInstanceUid", 64);
            internal readonly BigIntColumn Watermark = new BigIntColumn("Watermark");
            internal readonly TinyIntColumn Status = new TinyIntColumn("Status");
            internal readonly DateTime2Column LastStatusUpdatedDate = new DateTime2Column("LastStatusUpdatedDate", 7);
            internal readonly DateTime2Column CreatedDate = new DateTime2Column("CreatedDate", 7);
        }

        internal class SchemaVersionTable : Table
        {
            internal SchemaVersionTable(): base("dbo.SchemaVersion")
            {
            }

            internal readonly IntColumn Version = new IntColumn("Version");
            internal readonly VarCharColumn Status = new VarCharColumn("Status", 10);
        }

        internal class SeriesMetadataCoreTable : Table
        {
            internal SeriesMetadataCoreTable(): base("dbo.SeriesMetadataCore")
            {
            }

            internal readonly BigIntColumn StudyId = new BigIntColumn("StudyId");
            internal readonly VarCharColumn SeriesInstanceUid = new VarCharColumn("SeriesInstanceUid", 64);
            internal readonly IntColumn Version = new IntColumn("Version");
            internal readonly NullableNVarCharColumn Modality = new NullableNVarCharColumn("Modality", 16);
            internal readonly NullableDateColumn PerformedProcedureStepStartDate = new NullableDateColumn("PerformedProcedureStepStartDate");
        }

        internal class StudyMetadataCoreTable : Table
        {
            internal StudyMetadataCoreTable(): base("dbo.StudyMetadataCore")
            {
            }

            internal readonly BigIntColumn Id = new BigIntColumn("Id");
            internal readonly VarCharColumn StudyInstanceUid = new VarCharColumn("StudyInstanceUid", 64);
            internal readonly IntColumn Version = new IntColumn("Version");
            internal readonly NVarCharColumn PatientId = new NVarCharColumn("PatientId", 64);
            internal readonly NullableNVarCharColumn PatientName = new NullableNVarCharColumn("PatientName", 325);
            internal readonly NullableNVarCharColumn ReferringPhysicianName = new NullableNVarCharColumn("ReferringPhysicianName", 325);
            internal readonly NullableDateColumn StudyDate = new NullableDateColumn("StudyDate");
            internal readonly NullableNVarCharColumn StudyDescription = new NullableNVarCharColumn("StudyDescription", 64);
            internal readonly NullableNVarCharColumn AccessionNumber = new NullableNVarCharColumn("AccessionNumber", 16);
            internal const string PatientNameWords = "PatientNameWords";
        }

        internal class AddInstanceProcedure : StoredProcedure
        {
            internal AddInstanceProcedure(): base("dbo.AddInstance")
            {
            }

            private readonly ParameterDefinition<System.String> _studyInstanceUid = new ParameterDefinition<System.String>("@studyInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _seriesInstanceUid = new ParameterDefinition<System.String>("@seriesInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _sopInstanceUid = new ParameterDefinition<System.String>("@sopInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _patientId = new ParameterDefinition<System.String>("@patientId", global::System.Data.SqlDbType.NVarChar, false, 64);
            private readonly ParameterDefinition<System.String> _patientName = new ParameterDefinition<System.String>("@patientName", global::System.Data.SqlDbType.NVarChar, true, 325);
            private readonly ParameterDefinition<System.String> _referringPhysicianName = new ParameterDefinition<System.String>("@referringPhysicianName", global::System.Data.SqlDbType.NVarChar, true, 325);
            private readonly ParameterDefinition<System.Nullable<System.DateTime>> _studyDate = new ParameterDefinition<System.Nullable<System.DateTime>>("@studyDate", global::System.Data.SqlDbType.Date, true);
            private readonly ParameterDefinition<System.String> _studyDescription = new ParameterDefinition<System.String>("@studyDescription", global::System.Data.SqlDbType.NVarChar, true, 64);
            private readonly ParameterDefinition<System.String> _accessionNumber = new ParameterDefinition<System.String>("@accessionNumber", global::System.Data.SqlDbType.NVarChar, true, 64);
            private readonly ParameterDefinition<System.String> _modality = new ParameterDefinition<System.String>("@modality", global::System.Data.SqlDbType.NVarChar, true, 16);
            private readonly ParameterDefinition<System.Nullable<System.DateTime>> _performedProcedureStepStartDate = new ParameterDefinition<System.Nullable<System.DateTime>>("@performedProcedureStepStartDate", global::System.Data.SqlDbType.Date, true);
            private readonly ParameterDefinition<System.Byte> _initialStatus = new ParameterDefinition<System.Byte>("@initialStatus", global::System.Data.SqlDbType.TinyInt, false);
            public void PopulateCommand(SqlCommandWrapper command, System.String studyInstanceUid, System.String seriesInstanceUid, System.String sopInstanceUid, System.String patientId, System.String patientName, System.String referringPhysicianName, System.Nullable<System.DateTime> studyDate, System.String studyDescription, System.String accessionNumber, System.String modality, System.Nullable<System.DateTime> performedProcedureStepStartDate, System.Byte initialStatus)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddInstance";
                _studyInstanceUid.AddParameter(command.Parameters, studyInstanceUid);
                _seriesInstanceUid.AddParameter(command.Parameters, seriesInstanceUid);
                _sopInstanceUid.AddParameter(command.Parameters, sopInstanceUid);
                _patientId.AddParameter(command.Parameters, patientId);
                _patientName.AddParameter(command.Parameters, patientName);
                _referringPhysicianName.AddParameter(command.Parameters, referringPhysicianName);
                _studyDate.AddParameter(command.Parameters, studyDate);
                _studyDescription.AddParameter(command.Parameters, studyDescription);
                _accessionNumber.AddParameter(command.Parameters, accessionNumber);
                _modality.AddParameter(command.Parameters, modality);
                _performedProcedureStepStartDate.AddParameter(command.Parameters, performedProcedureStepStartDate);
                _initialStatus.AddParameter(command.Parameters, initialStatus);
            }
        }

        internal class DeleteDeletedInstanceProcedure : StoredProcedure
        {
            internal DeleteDeletedInstanceProcedure(): base("dbo.DeleteDeletedInstance")
            {
            }

            private readonly ParameterDefinition<System.String> _studyInstanceUid = new ParameterDefinition<System.String>("@studyInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _seriesInstanceUid = new ParameterDefinition<System.String>("@seriesInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _sopInstanceUid = new ParameterDefinition<System.String>("@sopInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.Int64> _watermark = new ParameterDefinition<System.Int64>("@watermark", global::System.Data.SqlDbType.BigInt, false);
            public void PopulateCommand(SqlCommandWrapper command, System.String studyInstanceUid, System.String seriesInstanceUid, System.String sopInstanceUid, System.Int64 watermark)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.DeleteDeletedInstance";
                _studyInstanceUid.AddParameter(command.Parameters, studyInstanceUid);
                _seriesInstanceUid.AddParameter(command.Parameters, seriesInstanceUid);
                _sopInstanceUid.AddParameter(command.Parameters, sopInstanceUid);
                _watermark.AddParameter(command.Parameters, watermark);
            }
        }

        internal class DeleteInstanceProcedure : StoredProcedure
        {
            internal DeleteInstanceProcedure(): base("dbo.DeleteInstance")
            {
            }

            private readonly ParameterDefinition<System.DateTimeOffset> _cleanupAfter = new ParameterDefinition<System.DateTimeOffset>("@cleanupAfter", global::System.Data.SqlDbType.DateTimeOffset, false, 0);
            private readonly ParameterDefinition<System.String> _studyInstanceUid = new ParameterDefinition<System.String>("@studyInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _seriesInstanceUid = new ParameterDefinition<System.String>("@seriesInstanceUid", global::System.Data.SqlDbType.VarChar, true, 64);
            private readonly ParameterDefinition<System.String> _sopInstanceUid = new ParameterDefinition<System.String>("@sopInstanceUid", global::System.Data.SqlDbType.VarChar, true, 64);
            public void PopulateCommand(SqlCommandWrapper command, System.DateTimeOffset cleanupAfter, System.String studyInstanceUid, System.String seriesInstanceUid, System.String sopInstanceUid)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.DeleteInstance";
                _cleanupAfter.AddParameter(command.Parameters, cleanupAfter);
                _studyInstanceUid.AddParameter(command.Parameters, studyInstanceUid);
                _seriesInstanceUid.AddParameter(command.Parameters, seriesInstanceUid);
                _sopInstanceUid.AddParameter(command.Parameters, sopInstanceUid);
            }
        }

        internal class GetChangeFeedProcedure : StoredProcedure
        {
            internal GetChangeFeedProcedure(): base("dbo.GetChangeFeed")
            {
            }

            private readonly ParameterDefinition<System.Int32> _limit = new ParameterDefinition<System.Int32>("@limit", global::System.Data.SqlDbType.Int, false);
            private readonly ParameterDefinition<System.Int64> _offset = new ParameterDefinition<System.Int64>("@offset", global::System.Data.SqlDbType.BigInt, false);
            public void PopulateCommand(SqlCommandWrapper command, System.Int32 limit, System.Int64 offset)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.GetChangeFeed";
                _limit.AddParameter(command.Parameters, limit);
                _offset.AddParameter(command.Parameters, offset);
            }
        }

        internal class GetChangeFeedLatestProcedure : StoredProcedure
        {
            internal GetChangeFeedLatestProcedure(): base("dbo.GetChangeFeedLatest")
            {
            }

            public void PopulateCommand(SqlCommandWrapper command)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.GetChangeFeedLatest";
            }
        }

        internal class GetInstanceProcedure : StoredProcedure
        {
            internal GetInstanceProcedure(): base("dbo.GetInstance")
            {
            }

            private readonly ParameterDefinition<System.Byte> _invalidStatus = new ParameterDefinition<System.Byte>("@invalidStatus", global::System.Data.SqlDbType.TinyInt, false);
            private readonly ParameterDefinition<System.String> _studyInstanceUid = new ParameterDefinition<System.String>("@studyInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _seriesInstanceUid = new ParameterDefinition<System.String>("@seriesInstanceUid", global::System.Data.SqlDbType.VarChar, true, 64);
            private readonly ParameterDefinition<System.String> _sopInstanceUid = new ParameterDefinition<System.String>("@sopInstanceUid", global::System.Data.SqlDbType.VarChar, true, 64);
            public void PopulateCommand(SqlCommandWrapper command, System.Byte invalidStatus, System.String studyInstanceUid, System.String seriesInstanceUid, System.String sopInstanceUid)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.GetInstance";
                _invalidStatus.AddParameter(command.Parameters, invalidStatus);
                _studyInstanceUid.AddParameter(command.Parameters, studyInstanceUid);
                _seriesInstanceUid.AddParameter(command.Parameters, seriesInstanceUid);
                _sopInstanceUid.AddParameter(command.Parameters, sopInstanceUid);
            }
        }

        internal class IncrementDeletedInstanceRetryProcedure : StoredProcedure
        {
            internal IncrementDeletedInstanceRetryProcedure(): base("dbo.IncrementDeletedInstanceRetry")
            {
            }

            private readonly ParameterDefinition<System.String> _studyInstanceUid = new ParameterDefinition<System.String>("@studyInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _seriesInstanceUid = new ParameterDefinition<System.String>("@seriesInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _sopInstanceUid = new ParameterDefinition<System.String>("@sopInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.Int64> _watermark = new ParameterDefinition<System.Int64>("@watermark", global::System.Data.SqlDbType.BigInt, false);
            private readonly ParameterDefinition<System.DateTimeOffset> _cleanupAfter = new ParameterDefinition<System.DateTimeOffset>("@cleanupAfter", global::System.Data.SqlDbType.DateTimeOffset, false, 0);
            public void PopulateCommand(SqlCommandWrapper command, System.String studyInstanceUid, System.String seriesInstanceUid, System.String sopInstanceUid, System.Int64 watermark, System.DateTimeOffset cleanupAfter)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.IncrementDeletedInstanceRetry";
                _studyInstanceUid.AddParameter(command.Parameters, studyInstanceUid);
                _seriesInstanceUid.AddParameter(command.Parameters, seriesInstanceUid);
                _sopInstanceUid.AddParameter(command.Parameters, sopInstanceUid);
                _watermark.AddParameter(command.Parameters, watermark);
                _cleanupAfter.AddParameter(command.Parameters, cleanupAfter);
            }
        }

        internal class RetrieveDeletedInstanceProcedure : StoredProcedure
        {
            internal RetrieveDeletedInstanceProcedure(): base("dbo.RetrieveDeletedInstance")
            {
            }

            private readonly ParameterDefinition<System.Int32> _count = new ParameterDefinition<System.Int32>("@count", global::System.Data.SqlDbType.Int, false);
            private readonly ParameterDefinition<System.Int32> _maxRetries = new ParameterDefinition<System.Int32>("@maxRetries", global::System.Data.SqlDbType.Int, false);
            public void PopulateCommand(SqlCommandWrapper command, System.Int32 count, System.Int32 maxRetries)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.RetrieveDeletedInstance";
                _count.AddParameter(command.Parameters, count);
                _maxRetries.AddParameter(command.Parameters, maxRetries);
            }
        }

        internal class SelectCurrentSchemaVersionProcedure : StoredProcedure
        {
            internal SelectCurrentSchemaVersionProcedure(): base("dbo.SelectCurrentSchemaVersion")
            {
            }

            public void PopulateCommand(SqlCommandWrapper command)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.SelectCurrentSchemaVersion";
            }
        }

        internal class UpdateInstanceStatusProcedure : StoredProcedure
        {
            internal UpdateInstanceStatusProcedure(): base("dbo.UpdateInstanceStatus")
            {
            }

            private readonly ParameterDefinition<System.String> _studyInstanceUid = new ParameterDefinition<System.String>("@studyInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _seriesInstanceUid = new ParameterDefinition<System.String>("@seriesInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.String> _sopInstanceUid = new ParameterDefinition<System.String>("@sopInstanceUid", global::System.Data.SqlDbType.VarChar, false, 64);
            private readonly ParameterDefinition<System.Int64> _watermark = new ParameterDefinition<System.Int64>("@watermark", global::System.Data.SqlDbType.BigInt, false);
            private readonly ParameterDefinition<System.Byte> _status = new ParameterDefinition<System.Byte>("@status", global::System.Data.SqlDbType.TinyInt, false);
            public void PopulateCommand(SqlCommandWrapper command, System.String studyInstanceUid, System.String seriesInstanceUid, System.String sopInstanceUid, System.Int64 watermark, System.Byte status)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.UpdateInstanceStatus";
                _studyInstanceUid.AddParameter(command.Parameters, studyInstanceUid);
                _seriesInstanceUid.AddParameter(command.Parameters, seriesInstanceUid);
                _sopInstanceUid.AddParameter(command.Parameters, sopInstanceUid);
                _watermark.AddParameter(command.Parameters, watermark);
                _status.AddParameter(command.Parameters, status);
            }
        }

        internal class UpsertSchemaVersionProcedure : StoredProcedure
        {
            internal UpsertSchemaVersionProcedure(): base("dbo.UpsertSchemaVersion")
            {
            }

            private readonly ParameterDefinition<System.Int32> _version = new ParameterDefinition<System.Int32>("@version", global::System.Data.SqlDbType.Int, false);
            private readonly ParameterDefinition<System.String> _status = new ParameterDefinition<System.String>("@status", global::System.Data.SqlDbType.VarChar, false, 10);
            public void PopulateCommand(SqlCommandWrapper command, System.Int32 version, System.String status)
            {
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.UpsertSchemaVersion";
                _version.AddParameter(command.Parameters, version);
                _status.AddParameter(command.Parameters, status);
            }
        }
    }
}