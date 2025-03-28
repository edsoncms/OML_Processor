using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssOMLProcessor {

	public class CssOMLProcessor: IssOMLProcessor {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOML"></param>
		/// <param name="sseSpaceName"></param>
		/// <param name="ssSoftwareUnits"></param>
		/// <param name="ssOmlReport"></param>
		public void MssAnalyzeOMLComplexity(byte[] ssOML, out string sseSpaceName, out int ssSoftwareUnits, out RLOmlReportRecordList ssOmlReport) {
			sseSpaceName = "";
			ssSoftwareUnits = 0;
			ssOmlReport = new RLOmlReportRecordList();
			// TODO: Write implementation for action
		} // MssAnalyzeOMLComplexity

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssName"></param>
		/// <param name="ssValidName"></param>
		public void MssCorrectName(string ssName, out string ssValidName) {
			ssValidName = "";
			// TODO: Write implementation for action
		} // MssCorrectName

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssComponentName"></param>
		/// <param name="ssComponentId"></param>
		/// <param name="ssIsExtension"></param>
		/// <param name="ssTimeout"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssCompleted"></param>
		/// <param name="ssCreateVersionSkipped"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssGetCompilerResult(string ssComponentName, int ssComponentId, bool ssIsExtension, int ssTimeout, string ssUsername, out bool ssCompleted, out bool ssCreateVersionSkipped, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssCompleted = false;
			ssCreateVersionSkipped = false;
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssGetCompilerResult

		/// <summary>
		/// Extracts eSpace information from the OML header and some fragments.
		/// NOTE: This API doesn&apos;t work with partial OMLs, because it requires fragment information that might not be available. For partial OMLs, use GetEspaceInfoFromOMLHeader instead.
		/// </summary>
		/// <param name="ssOML"></param>
		/// <param name="ssinfo"></param>
		public void MssGetEspaceInfoFromOML(byte[] ssOML, out RCESpaceDetailedInfoRecord ssinfo) {
			ssinfo = new RCESpaceDetailedInfoRecord(null);
			// TODO: Write implementation for action
		} // MssGetEspaceInfoFromOML

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSMSConnectorPort"></param>
		/// <param name="ssSchedulerPort"></param>
		/// <param name="ssDeploymentPort"></param>
		/// <param name="ssControllerPort"></param>
		/// <param name="ssLogPort"></param>
		/// <param name="ssControllerAddress"></param>
		public void MssGetServiceConfiguration(out string ssSMSConnectorPort, out string ssSchedulerPort, out string ssDeploymentPort, out string ssControllerPort, out string ssLogPort, out string ssControllerAddress) {
			ssSMSConnectorPort = "";
			ssSchedulerPort = "";
			ssDeploymentPort = "";
			ssControllerPort = "";
			ssLogPort = "";
			ssControllerAddress = "";
			// TODO: Write implementation for action
		} // MssGetServiceConfiguration

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssHostAddress"></param>
		/// <param name="ssServicePort"></param>
		/// <param name="ssQueues"></param>
		/// <param name="ssThreads"></param>
		/// <param name="ssUtcInSeconds">Returns information about the UTC value in the frontend/controller the service is running</param>
		public void MssGetServiceStatus(string ssHostAddress, string ssServicePort, out RLQueueStatusRecordList ssQueues, out RLThreadStatusRecordList ssThreads, out long ssUtcInSeconds) {
			ssQueues = new RLQueueStatusRecordList();
			ssThreads = new RLThreadStatusRecordList();
			ssUtcInSeconds = 0L;
			// TODO: Write implementation for action
		} // MssGetServiceStatus

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sshost"></param>
		/// <param name="ssapplication"></param>
		/// <param name="sstimeout"></param>
		/// <param name="ssstatus"></param>
		public void MssPingApplication(string sshost, string ssapplication, int sstimeout, out string ssstatus) {
			ssstatus = "";
			// TODO: Write implementation for action
		} // MssPingApplication

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssTenantId"></param>
		public void MssRedeployTenant(int ssTenantId) {
			// TODO: Write implementation for action
		} // MssRedeployTenant

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssText"></param>
		/// <param name="ssPattern"></param>
		/// <param name="ssFound"></param>
		public void MssRegExpExists(string ssText, string ssPattern, out bool ssFound) {
			ssFound = false;
			// TODO: Write implementation for action
		} // MssRegExpExists

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sstenantId"></param>
		/// <param name="sspattern"></param>
		/// <param name="ssresult"></param>
		public void MssResolveSmsPattern(int sstenantId, string sspattern, out string ssresult) {
			ssresult = "";
			// TODO: Write implementation for action
		} // MssResolveSmsPattern

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssespaceName"></param>
		/// <param name="ssespaceVersionId"></param>
		/// <param name="ssuserId"></param>
		/// <param name="ssrefreshReferences"></param>
		/// <param name="ssMessages"></param>
		public void MssVerifyOmlInServiceStudioAsync(string ssespaceName, int ssespaceVersionId, int ssuserId, bool ssrefreshReferences, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssVerifyOmlInServiceStudioAsync

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssOML"></param>
		/// <param name="ssQueryCompoundKey"></param>
		/// <param name="ssMaxRecords"></param>
		/// <param name="ssResultCode"></param>
		/// <param name="ssQueryResult"></param>
		/// <param name="ssErrorText"></param>
		/// <param name="ssExecutedSQL"></param>
		/// <param name="ssAdvancedSQL"></param>
		public void MssTestQuery(string ssOperationId, int ssEspaceId, string ssEspaceName, int ssTenantId, byte[] ssOML, string ssQueryCompoundKey, int ssMaxRecords, out string ssResultCode, out string ssQueryResult, out string ssErrorText, out string ssExecutedSQL, out string ssAdvancedSQL) {
			ssResultCode = "";
			ssQueryResult = "";
			ssErrorText = "";
			ssExecutedSQL = "";
			ssAdvancedSQL = "";
			// TODO: Write implementation for action
		} // MssTestQuery

		/// <summary>
		/// 
		/// </summary>
		public void MssPerfCounter_Stop() {
			// TODO: Write implementation for action
		} // MssPerfCounter_Stop

		/// <summary>
		/// 
		/// </summary>
		public void MssPerfCounter_Start() {
			// TODO: Write implementation for action
		} // MssPerfCounter_Start

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProcMemData"></param>
		/// <param name="ssElapsedTime"></param>
		public void MssPerfCounter_GetData(out RLProcessMemDataRecordList ssProcMemData, out decimal ssElapsedTime) {
			ssProcMemData = new RLProcessMemDataRecordList();
			ssElapsedTime = 0.0M;
			// TODO: Write implementation for action
		} // MssPerfCounter_GetData

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProcList"></param>
		public void MssPerfCounter_Config(RLProcessConfigRecordList ssProcList) {
			// TODO: Write implementation for action
		} // MssPerfCounter_Config

		/// <summary>
		/// Used to implement AJAX patterns
		/// </summary>
		/// <param name="ssText">The text to be converted</param>
		/// <param name="ssEncoding">The encoding to be applied using .NET method Encoding.GetEncoding (ex: utf-8). </param>
		/// <param name="ssBin">The binary content returned</param>
		public void MssTextToBin(string ssText, string ssEncoding, out byte[] ssBin) {
			ssBin = new byte[] {};
			// TODO: Write implementation for action
		} // MssTextToBin

		/// <summary>
		/// calculates a timer next run based on the given schedule
		/// </summary>
		/// <param name="ssSchedule"></param>
		/// <param name="ssCurrDateTime"></param>
		/// <param name="ssLastRun"></param>
		/// <param name="ssNextRun"></param>
		public void MssTimerNextRun(string ssSchedule, DateTime ssCurrDateTime, DateTime ssLastRun, out DateTime ssNextRun) {
			ssNextRun = new DateTime(1900, 1, 1, 0, 0, 0);
			// TODO: Write implementation for action
		} // MssTimerNextRun

		/// <summary>
		/// Outputs the Hub Controller Service Studio Version and LastUpgrade Version
		/// </summary>
		/// <param name="ssVersion">The release/patch version</param>
		/// <param name="ssLastUpgradeVersion">The schema version</param>
		public void MssGetServiceStudioVersion(out string ssVersion, out string ssLastUpgradeVersion) {
			ssVersion = "";
			ssLastUpgradeVersion = "";
			// TODO: Write implementation for action
		} // MssGetServiceStudioVersion

		/// <summary>
		/// Gets the current HTTP request context.
		/// </summary>
		/// <param name="ssIsLocal">If true, the URL host part will be replaced with &apos;127.0.0.1&apos;.</param>
		/// <param name="ssURL">The requested URL</param>
		/// <param name="ssMethod">The request method (&quot;GET&quot; or &quot;POST&quot;)</param>
		public void MssGetCurrentURL(bool ssIsLocal, out string ssURL, out string ssMethod) {
			ssURL = "";
			ssMethod = "";
			// TODO: Write implementation for action
		} // MssGetCurrentURL

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssDebug"></param>
		/// <param name="ssOML"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssSkipDeploy"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssApplicationName"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssPTAOwner"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssPublishEspacePartial(string ssOperationId, bool ssDebug, byte[] ssOML, string ssEspaceName, string ssEspaceKey, bool ssSkipDeploy, string ssUniqueId, string ssApplicationName, string ssApplicationKey, string ssPTAOwner, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssPublishEspacePartial

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssESpaceName"></param>
		/// <param name="ssPTA"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssOk"></param>
		public void MssCanUseExistingPartialOml(string ssESpaceName, string ssPTA, string ssUniqueId, out bool ssOk) {
			ssOk = false;
			// TODO: Write implementation for action
		} // MssCanUseExistingPartialOml

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProperty"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetLicenseProperty(string ssProperty, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetLicenseProperty

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetAvailableFeatureLimit(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetAvailableFeatureLimit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssOperation"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationDoFeatureOperation(string ssFeatureId, string ssOperation, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationDoFeatureOperation

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssCompilerMessage"></param>
		/// <param name="ssHEMessage"></param>
		public void MssCompilerMessageToHEMessage(object ssCompilerMessage, out RCHEMessageRecord ssHEMessage) {
			ssHEMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssCompilerMessageToHEMessage

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationRefreshState(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationRefreshState

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetExceedingFeatureLimit(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetExceedingFeatureLimit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssOperation"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationCanDoFeatureOperation(string ssFeatureId, string ssOperation, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationCanDoFeatureOperation

		/// <summary>
		/// If you only need one property, please use ActivationGetLicenseProperty instead as it will be much faster.
		/// </summary>
		/// <param name="ssLicenceInformation"></param>
		public void MssActivationGetLicenseInformation(out RCActivationLicenseInformationRecord ssLicenceInformation) {
			ssLicenceInformation = new RCActivationLicenseInformationRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetLicenseInformation

		/// <summary>
		/// Answer is one of:
		/// 
		/// NoLicense
		/// InvalidLicense
		/// ViolatingTerm
		/// ViolatingFeatures
		/// InsideTermGrace
		/// InsideFeaturesGrace
		/// InsideTermWarn
		/// OK
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationGetLicenseState(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetLicenseState

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetFeatureLimit(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetFeatureLimit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponses"></param>
		public void MssActivationGetLicenseFeatures(out RLActivationResponseRecordList ssResponses) {
			ssResponses = new RLActivationResponseRecordList();
			// TODO: Write implementation for action
		} // MssActivationGetLicenseFeatures

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetFeatureName(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetFeatureName

		/// <summary>
		/// Answer is one of:
		/// 
		/// NoLicense
		/// Violating
		/// InsideGrace
		/// OK
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetFeatureState(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetFeatureState

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetConsumedFeatureLimit(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetConsumedFeatureLimit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationGetMachineIdentification(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetMachineIdentification

		/// <summary>
		/// Gets the absolute referrer url of the client&apos;s previous request.
		/// </summary>
		/// <param name="ssReferrer">The absolute referrer url of the client&apos;s previous request.</param>
		public void MssGetReferrer(out string ssReferrer) {
			ssReferrer = "";
			// TODO: Write implementation for action
		} // MssGetReferrer

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetFeatureGrace(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetFeatureGrace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssParameter"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetCustomFeatureMessage(string ssFeatureId, string ssParameter, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetCustomFeatureMessage

		/// <summary>
		/// Returns the manifest xml of a given Solution Pack given the meta information received.
		/// </summary>
		/// <param name="ssSolutionPack"></param>
		/// <param name="ssXml"></param>
		public void MssSolutionPackToXml(RCSolutionPackRecord ssSolutionPack, out string ssXml) {
			ssXml = "";
			// TODO: Write implementation for action
		} // MssSolutionPackToXml

		/// <summary>
		/// Returns a Solution Pack given a manifest xml.
		/// </summary>
		/// <param name="ssXml"></param>
		/// <param name="ssPack"></param>
		public void MssSolutionPackFromXml(string ssXml, out RCSolutionPackRecord ssPack) {
			ssPack = new RCSolutionPackRecord(null);
			// TODO: Write implementation for action
		} // MssSolutionPackFromXml

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSolutionPack"></param>
		/// <param name="ssSolutionPackFiles"></param>
		/// <param name="ssFile"></param>
		public void MssSolutionPackToFile(RCSolutionPackRecord ssSolutionPack, RLSolutionPack_FileRecordList ssSolutionPackFiles, out byte[] ssFile) {
			ssFile = new byte[] {};
			// TODO: Write implementation for action
		} // MssSolutionPackToFile

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFile"></param>
		/// <param name="ssSolutionPack"></param>
		/// <param name="ssSolutionFiles"></param>
		public void MssSolutionPackFromFile(byte[] ssFile, out RCSolutionPackRecord ssSolutionPack, out RLSolutionPack_FileRecordList ssSolutionFiles) {
			ssSolutionPack = new RCSolutionPackRecord(null);
			ssSolutionFiles = new RLSolutionPack_FileRecordList();
			// TODO: Write implementation for action
		} // MssSolutionPackFromFile

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFile"></param>
		/// <param name="ssUpgraded"></param>
		/// <param name="ssUpgradedFile"></param>
		/// <param name="ssMessages"></param>
		public void MssSolutionPackUpgrade(byte[] ssFile, out bool ssUpgraded, out byte[] ssUpgradedFile, out RLHEMessageRecordList ssMessages) {
			ssUpgraded = false;
			ssUpgradedFile = new byte[] {};
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssSolutionPackUpgrade

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFile"></param>
		/// <param name="ssUID"></param>
		/// <param name="ssCreation"></param>
		/// <param name="ssSchemaVersion"></param>
		/// <param name="ssMessage"></param>
		/// <param name="ssActivationCode"></param>
		/// <param name="ssProductId"></param>
		/// <param name="ssProductName"></param>
		/// <param name="ssSolutionUID"></param>
		/// <param name="ssHasAgilePlatformApplication"></param>
		/// <param name="ssSolutionVersionUID"></param>
		/// <param name="ssIsSolution"></param>
		/// <param name="ssApplicationKeys"></param>
		public void MssSolutionPackGetInfo(byte[] ssFile, out string ssUID, out DateTime ssCreation, out int ssSchemaVersion, out RCHEMessageRecord ssMessage, out string ssActivationCode, out string ssProductId, out string ssProductName, out string ssSolutionUID, out bool ssHasAgilePlatformApplication, out string ssSolutionVersionUID, out bool ssIsSolution, out RLTextRecordList ssApplicationKeys) {
			ssUID = "";
			ssCreation = new DateTime(1900, 1, 1, 0, 0, 0);
			ssSchemaVersion = 0;
			ssMessage = new RCHEMessageRecord(null);
			ssActivationCode = "";
			ssProductId = "";
			ssProductName = "";
			ssSolutionUID = "";
			ssHasAgilePlatformApplication = false;
			ssSolutionVersionUID = "";
			ssIsSolution = false;
			ssApplicationKeys = new RLTextRecordList();
			// TODO: Write implementation for action
		} // MssSolutionPackGetInfo

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFile"></param>
		/// <param name="ssXml"></param>
		/// <param name="ssMessage"></param>
		public void MssSolutionPackGetXml(byte[] ssFile, out string ssXml, out RCHEMessageRecord ssMessage) {
			ssXml = "";
			ssMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssSolutionPackGetXml

		/// <summary>
		/// Makes an assynchronous GET request. If Login is true, the parameters UserId and UserPassword will be added to the request using the current Session information.
		/// </summary>
		/// <param name="ssURL">Relative URL to servername.</param>
		public void MssGetURLAsync(string ssURL) {
			// TODO: Write implementation for action
		} // MssGetURLAsync

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssSkipConsistencyMessages"></param>
		/// <param name="ssForceDontReuseTables"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssUpdateEspaceDBModel(string ssOperationId, string ssEspaceName, int ssEspaceVersionId, bool ssSkipConsistencyMessages, bool ssForceDontReuseTables, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssUpdateEspaceDBModel

		/// <summary>
		/// No PTA&apos;s will be updated.
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssProducers"></param>
		/// <param name="ssWithoutImpactAnalysis"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssForceFirstLoad"></param>
		/// <param name="ssAllowSkipCompilation"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssCompileEspaceWithEmptyProxies(string ssOperationId, string ssEspaceName, int ssEspaceVersionId, RLReferenceRecordList ssProducers, bool ssWithoutImpactAnalysis, string ssUniqueId, string ssUsername, bool ssForceFirstLoad, bool ssAllowSkipCompilation, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssCompileEspaceWithEmptyProxies

		/// <summary>
		/// No PTA&apos;s will be updated.
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssProducers"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssCompileEspaceProxies(string ssOperationId, string ssEspaceName, int ssEspaceVersionId, RLReferenceRecordList ssProducers, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssCompileEspaceProxies

		/// <summary>
		/// Simply pulls the producers assemblies, dependencies and reference proxies.
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssProducers">Acceptable producers to pull proxies from. Proxies of producers not on this list will not be pulled.</param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssPullEspaceProducers(string ssOperationId, string ssEspaceName, int ssEspaceVersionId, RLReferenceRecordList ssProducers, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssPullEspaceProducers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationGetServerMode(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetServerMode

		/// <summary>
		/// Sets the server purpose for the environment.
		/// </summary>
		/// <param name="ssServerPurpose">One of the values recognized as valid server purposes by the platform: &quot;Development&quot;, &quot;NonProduction&quot;, &quot;Management&quot;, &quot;DisasterRecovery&quot;,  and &quot;Production&quot;.</param>
		/// <param name="ssResponse"></param>
		public void MssActivationSetServerPurpose(string ssServerPurpose, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationSetServerPurpose

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureIds"></param>
		/// <param name="ssisSynchronous"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationRefreshFeatureState(RLFeatureRecordList ssFeatureIds, bool ssisSynchronous, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationRefreshFeatureState

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssProducerName"></param>
		/// <param name="ssConsumerName"></param>
		/// <param name="ssTestAreaName"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssMessages"></param>
		public void MssPushProducer(string ssOperationId, string ssProducerName, string ssConsumerName, string ssTestAreaName, string ssUniqueId, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssPushProducer

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssProducers"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssEspaceCleanCodeCompile(string ssOperationId, string ssEspaceName, int ssEspaceVersionId, RLReferenceRecordList ssProducers, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssEspaceCleanCodeCompile

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssEspaceCleanCodePack(string ssOperationId, string ssEspaceName, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssEspaceCleanCodePack

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssPack"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssEspaceCleanCodeGetPack(string ssOperationId, string ssEspaceName, string ssUniqueId, out byte[] ssPack, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssPack = new byte[] {};
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssEspaceCleanCodeGetPack

		/// <summary>
		/// This action overrides the .NET framework request timeout for the current request.
		/// </summary>
		/// <param name="ssTimeout">The new timeout, in seconds. Will use MaxInteger if a negative value is passed.</param>
		public void MssSetRequestTimeout(int ssTimeout) {
			// TODO: Write implementation for action
		} // MssSetRequestTimeout

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssxmlError"></param>
		/// <param name="ssErrorText"></param>
		public void MssXMLErrorToText(string ssxmlError, out string ssErrorText) {
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssXMLErrorToText

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssForceRefresh"></param>
		/// <param name="ssEncrypt"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetServerAudit(bool ssForceRefresh, bool ssEncrypt, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetServerAudit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssVersion">The release/patch version</param>
		/// <param name="ssLastUpgradeVersion">The schema version</param>
		public void MssGetIntegrationStudioVersion(out string ssVersion, out string ssLastUpgradeVersion) {
			ssVersion = "";
			ssLastUpgradeVersion = "";
			// TODO: Write implementation for action
		} // MssGetIntegrationStudioVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssextensionName"></param>
		/// <param name="ssextensionVersionId"></param>
		/// <param name="ssdeveloperId"></param>
		/// <param name="ssMessages"></param>
		public void MssVerifyXifInIntegrationStudioAsync(string ssextensionName, int ssextensionVersionId, int ssdeveloperId, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssVerifyXifInIntegrationStudioAsync

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssXIF"></param>
		/// <param name="ssExtension_name"></param>
		/// <param name="ssExtension_UID"></param>
		/// <param name="ssExtension_System"></param>
		/// <param name="ssExtension_valid"></param>
		/// <param name="ssExtension_IntegrationStudioVersion"></param>
		/// <param name="ssExtension_LastUpgradeVersion"></param>
		/// <param name="ssExtension_Description"></param>
		/// <param name="ssExtension_Hash"></param>
		/// <param name="ssExtension_LastModified"></param>
		/// <param name="ssExtension_Actions"></param>
		/// <param name="ssExtension_Structures"></param>
		/// <param name="ssExtension_Entities"></param>
		/// <param name="ssExtension_HasSAP"></param>
		/// <param name="ssExtension_HasLogicalDatabase"></param>
		/// <param name="ssExtension_HasLDAP"></param>
		/// <param name="ssActivationCode"></param>
		/// <param name="ssProductId"></param>
		/// <param name="ssProductName"></param>
		/// <param name="ssExtension_DirectUpgradeFrom">Set only when this eSpace version is the result of a direct upgrade, in which case it contains the hash before the upgrade</param>
		/// <param name="ssExtension_Complexity">The number of SUs or AOs that this extension requires.</param>
		public void MssGetExtensionInfoFromXIF(byte[] ssXIF, out string ssExtension_name, out string ssExtension_UID, out bool ssExtension_System, out bool ssExtension_valid, out string ssExtension_IntegrationStudioVersion, out string ssExtension_LastUpgradeVersion, out string ssExtension_Description, out string ssExtension_Hash, out DateTime ssExtension_LastModified, out int ssExtension_Actions, out int ssExtension_Structures, out int ssExtension_Entities, out bool ssExtension_HasSAP, out bool ssExtension_HasLogicalDatabase, out bool ssExtension_HasLDAP, out string ssActivationCode, out string ssProductId, out string ssProductName, out string ssExtension_DirectUpgradeFrom, out int ssExtension_Complexity) {
			ssExtension_name = "";
			ssExtension_UID = "";
			ssExtension_System = false;
			ssExtension_valid = false;
			ssExtension_IntegrationStudioVersion = "";
			ssExtension_LastUpgradeVersion = "";
			ssExtension_Description = "";
			ssExtension_Hash = "";
			ssExtension_LastModified = new DateTime(1900, 1, 1, 0, 0, 0);
			ssExtension_Actions = 0;
			ssExtension_Structures = 0;
			ssExtension_Entities = 0;
			ssExtension_HasSAP = false;
			ssExtension_HasLogicalDatabase = false;
			ssExtension_HasLDAP = false;
			ssActivationCode = "";
			ssProductId = "";
			ssProductName = "";
			ssExtension_DirectUpgradeFrom = "";
			ssExtension_Complexity = 0;
			// TODO: Write implementation for action
		} // MssGetExtensionInfoFromXIF

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssVersionId"></param>
		/// <param name="ssDeveloperId"></param>
		/// <param name="ssSwitchPublishedVersion">If false, the version that is considered to be published is still the previous one.</param>
		/// <param name="ssFromSolutionPublish">When publishing from a solution, the SU/AO conumption will not be done (it will have been done before in the previous steps of solution publish)</param>
		/// <param name="ssMessages"></param>
		public void MssPublishExtension(int ssVersionId, int ssDeveloperId, bool ssSwitchPublishedVersion, bool ssFromSolutionPublish, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssPublishExtension

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssXIF"></param>
		/// <param name="ssSmashRunningVersion"></param>
		/// <param name="ssDeveloperId"></param>
		/// <param name="ssCommitMessage"></param>
		/// <param name="ssExtensionId"></param>
		/// <param name="ssExtensionVersionId"></param>
		/// <param name="ssMessage"></param>
		public void MssUploadExtension(byte[] ssXIF, bool ssSmashRunningVersion, int ssDeveloperId, string ssCommitMessage, out int ssExtensionId, out int ssExtensionVersionId, out RCHEMessageRecord ssMessage) {
			ssExtensionId = 0;
			ssExtensionVersionId = 0;
			ssMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssUploadExtension

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationDoFeatureFix(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationDoFeatureFix

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationCanDoFeatureFix(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationCanDoFeatureFix

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sstext"></param>
		/// <param name="ssEncodedText"></param>
		public void MssEncodeUrlDefaultEncoding(string sstext, out string ssEncodedText) {
			ssEncodedText = "";
			// TODO: Write implementation for action
		} // MssEncodeUrlDefaultEncoding

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDetailedVersion"></param>
		public void MssGetDetailedVersion(out string ssDetailedVersion) {
			ssDetailedVersion = "";
			// TODO: Write implementation for action
		} // MssGetDetailedVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSetting"></param>
		/// <param name="ssEncryptedSetting"></param>
		public void MssEncryptSetting(string ssSetting, out string ssEncryptedSetting) {
			ssEncryptedSetting = "";
			// TODO: Write implementation for action
		} // MssEncryptSetting

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSetting"></param>
		/// <param name="ssDecryptedSetting"></param>
		public void MssDecryptSetting(string ssSetting, out string ssDecryptedSetting) {
			ssDecryptedSetting = "";
			// TODO: Write implementation for action
		} // MssDecryptSetting

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssText"></param>
		/// <param name="ssPattern"></param>
		/// <param name="ssParsedText"></param>
		public void MssRegExp(string ssText, string ssPattern, out string ssParsedText) {
			ssParsedText = "";
			// TODO: Write implementation for action
		} // MssRegExp

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFile"></param>
		/// <param name="ssReferences"></param>
		public void MssSolutionReferencesFromFile(byte[] ssFile, out RLSolutionPack_SolutionReferenceRecordList ssReferences) {
			ssReferences = new RLSolutionPack_SolutionReferenceRecordList();
			// TODO: Write implementation for action
		} // MssSolutionReferencesFromFile

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDBConfig"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssMessage"></param>
		public void MssDALDBConfigTest(object ssDBConfig, out bool ssSuccess, out string ssMessage) {
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDALDBConfigTest

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEntityGUID"></param>
		/// <param name="ssEspaceGUID"></param>
		/// <param name="ssRecords"></param>
		/// <param name="ssErrorText"></param>
		public void MssGetEntityData(string ssEntityGUID, string ssEspaceGUID, out RLAbstractRecordRecordList ssRecords, out string ssErrorText) {
			ssRecords = new RLAbstractRecordRecordList();
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssGetEntityData

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssslowType"></param>
		/// <param name="ssthreshold"></param>
		public void MssGetSlowThreshold(string ssslowType, out int ssthreshold) {
			ssthreshold = 0;
			// TODO: Write implementation for action
		} // MssGetSlowThreshold

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOML"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		public void MssImpactAnalysisAsync(byte[] ssOML, string ssEspaceName, int ssEspaceVersionId, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssImpactAnalysisAsync

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssActivityId"></param>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssActivityDefinitionKey"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssFailureMessage"></param>
		public void MssBPMActivitySkip(int ssActivityId, string ssModuleKey, string ssActivityDefinitionKey, int ssTenantId, int ssProcessId, out bool ssSuccess, out string ssFailureMessage) {
			ssSuccess = false;
			ssFailureMessage = "";
			// TODO: Write implementation for action
		} // MssBPMActivitySkip

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssActivityId"></param>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssActivityDefinitionKey"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssCurrentStatus"></param>
		/// <param name="ssSuccess"></param>
		public void MssBPMActivityRetry(int ssActivityId, string ssModuleKey, string ssActivityDefinitionKey, int ssTenantId, int ssProcessId, int ssCurrentStatus, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssBPMActivityRetry

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sshostname"></param>
		/// <param name="ssport"></param>
		public void MssServiceReloadSettings(string sshostname, string ssport) {
			// TODO: Write implementation for action
		} // MssServiceReloadSettings

		/// <summary>
		/// Used to house keep BPM Event tables
		/// </summary>
		/// <param name="ssTableName"></param>
		/// <param name="ssEspaceId"></param>
		public void MssBPMEventTableCleanUp(string ssTableName, int ssEspaceId) {
			// TODO: Write implementation for action
		} // MssBPMEventTableCleanUp

		/// <summary>
		/// Used to clean activities that are running past the specified datetime
		/// </summary>
		/// <param name="ssLimitDate"></param>
		public void MssBPMCleanUpActivitiesOlderThan(DateTime ssLimitDate) {
			// TODO: Write implementation for action
		} // MssBPMCleanUpActivitiesOlderThan

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssloopback"></param>
		public void MssIsLoopbackRequest(out bool ssloopback) {
			ssloopback = false;
			// TODO: Write implementation for action
		} // MssIsLoopbackRequest

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOML"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		public void MssImpactAnalysis(byte[] ssOML, string ssEspaceName, int ssEspaceVersionId, string ssUsername, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssImpactAnalysis

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssmessage"></param>
		public void MssOSTraceDebug(string ssmessage) {
			// TODO: Write implementation for action
		} // MssOSTraceDebug

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssmessage"></param>
		public void MssOSTraceInfo(string ssmessage) {
			// TODO: Write implementation for action
		} // MssOSTraceInfo

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssmessage"></param>
		public void MssOSTraceWarning(string ssmessage) {
			// TODO: Write implementation for action
		} // MssOSTraceWarning

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssmessage"></param>
		public void MssOSTraceError(string ssmessage) {
			// TODO: Write implementation for action
		} // MssOSTraceError

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sstimerName"></param>
		public void MssOSTraceTimerStart(string sstimerName) {
			// TODO: Write implementation for action
		} // MssOSTraceTimerStart

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sstimerName"></param>
		public void MssOSTraceTimerEnd(string sstimerName) {
			// TODO: Write implementation for action
		} // MssOSTraceTimerEnd

		/// <summary>
		/// Checks if the feature is supported.
		/// If not, we can disable/hide their use cases in Service Center.
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationIsFeatureSupported(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationIsFeatureSupported

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSignature"></param>
		/// <param name="ssHasPublicElements"></param>
		public void MssCheckEspaceSignatureHasPublicElements(byte[] ssSignature, out bool ssHasPublicElements) {
			ssHasPublicElements = false;
			// TODO: Write implementation for action
		} // MssCheckEspaceSignatureHasPublicElements

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssIncoming"></param>
		/// <param name="ssTargetPage"></param>
		/// <param name="ssPageRuleIncoming"></param>
		/// <param name="ssPageRuleTranslation"></param>
		public void MssGeneratePageRuleFromMetaRuleInfo(string ssIncoming, string ssTargetPage, out string ssPageRuleIncoming, out string ssPageRuleTranslation) {
			ssPageRuleIncoming = "";
			ssPageRuleTranslation = "";
			// TODO: Write implementation for action
		} // MssGeneratePageRuleFromMetaRuleInfo

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sstext"></param>
		/// <param name="ssEncodedText"></param>
		public void MssEncodeUrlPath(string sstext, out string ssEncodedText) {
			ssEncodedText = "";
			// TODO: Write implementation for action
		} // MssEncodeUrlPath

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssAjax"></param>
		public void MssIsAjaxRequest(out bool ssAjax) {
			ssAjax = false;
			// TODO: Write implementation for action
		} // MssIsAjaxRequest

		/// <summary>
		/// Invalidate the tenant cache of all the espaces in the provided catalog and their consumers if requested
		/// </summary>
		/// <param name="ssDbCatalogId"></param>
		/// <param name="ssIncludeConsumers"></param>
		/// <param name="ssMessages"></param>
		public void MssDBCatalogTenantInvalidateCache(int ssDbCatalogId, bool ssIncludeConsumers, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDBCatalogTenantInvalidateCache

		/// <summary>
		/// Test that a given catalog is correctly setup
		/// </summary>
		/// <param name="ssCatalogName"></param>
		/// <param name="ssRuntimeUser"></param>
		/// <param name="ssPassword"></param>
		/// <param name="ssOwnerUser"></param>
		/// <param name="ssOwnerPassword"></param>
		/// <param name="ssTablespace"></param>
		/// <param name="ssUseIntegratedAuthentication"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssErrorMessage"></param>
		public void MssDBCatalogTestConnection(string ssCatalogName, string ssRuntimeUser, string ssPassword, string ssOwnerUser, string ssOwnerPassword, string ssTablespace, bool ssUseIntegratedAuthentication, out bool ssSuccess, out string ssErrorMessage) {
			ssSuccess = false;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssDBCatalogTestConnection

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDbCatalogId"></param>
		/// <param name="ssIncludeConsumers"></param>
		/// <param name="ssEspaceList"></param>
		public void MssDBCatalogGetEspaces(int ssDbCatalogId, bool ssIncludeConsumers, out RLIntegerRecordList ssEspaceList) {
			ssEspaceList = new RLIntegerRecordList();
			// TODO: Write implementation for action
		} // MssDBCatalogGetEspaces

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="sseSpaceName"></param>
		/// <param name="sseSpaceVersion"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssFoundMatchingTables">True if tables that match the required format were found in the target catalog.</param>
		public void MssCheckMatchingTables(string ssOperationId, string sseSpaceName, int sseSpaceVersion, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages, out bool ssFoundMatchingTables) {
			ssMessages = new RLHEMessageRecordList();
			ssFoundMatchingTables = false;
			// TODO: Write implementation for action
		} // MssCheckMatchingTables

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="sseSpaceName"></param>
		/// <param name="sseSpaceVersion"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssMessages"></param>
		public void MssCheckMatchingTablesAsync(string ssOperationId, string sseSpaceName, int sseSpaceVersion, string ssUniqueId, string ssUsername, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssCheckMatchingTablesAsync

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSerial"></param>
		public void MssGetCurrentMachineSerial(out string ssSerial) {
			ssSerial = "";
			// TODO: Write implementation for action
		} // MssGetCurrentMachineSerial

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssURL"></param>
		/// <param name="ssStatusLine"></param>
		/// <param name="ssResponseBody"></param>
		/// <param name="ssStatusCode"></param>
		public void MssGetURL(string ssURL, out string ssStatusLine, out string ssResponseBody, out int ssStatusCode) {
			ssStatusLine = "";
			ssResponseBody = "";
			ssStatusCode = 0;
			// TODO: Write implementation for action
		} // MssGetURL

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResult"></param>
		public void MssGetSupportLegacyAuthentication(out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssGetSupportLegacyAuthentication

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationGetCloudProvider(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetCloudProvider

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssESpaceName"></param>
		/// <param name="ssAction"></param>
		/// <param name="ssParameters"></param>
		/// <param name="ssResultCode"></param>
		/// <param name="ssResult"></param>
		/// <param name="ssErrorText"></param>
		public void MssTestAction(string ssESpaceName, string ssAction, RLTextRecordList ssParameters, out string ssResultCode, out string ssResult, out string ssErrorText) {
			ssResultCode = "";
			ssResult = "";
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssTestAction

		/// <summary>
		/// Gets the exceptions and respective stacktraces of the current request
		/// </summary>
		/// <param name="ssExceptions"></param>
		public void MssGetCurrentExceptions(out RLHEMessageRecordList ssExceptions) {
			ssExceptions = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssGetCurrentExceptions

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResult"></param>
		public void MssGetUsingSandboxMode(out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssGetUsingSandboxMode

		/// <summary>
		/// Create processes scripts only for an eSpace for solution publish.
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssProducers"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssCompileOmlImpactAnalysisOnlyWithScripts(string ssOperationId, string ssEspaceName, int ssEspaceVersionId, string ssUniqueId, string ssUsername, RLReferenceRecordList ssProducers, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssCompileOmlImpactAnalysisOnlyWithScripts

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssUserName"></param>
		/// <param name="ssOperationId"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssDeploymentId"></param>
		/// <param name="ssMessages"></param>
		public void MssDeployAbort(string ssEspaceName, string ssUserName, string ssOperationId, string ssUniqueId, string ssDeploymentId, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDeployAbort

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssURL"></param>
		/// <param name="ssParameters"></param>
		/// <param name="ssOk"></param>
		public void MssPostRequest(string ssURL, RLKeyValuePairRecordList ssParameters, out bool ssOk) {
			ssOk = false;
			// TODO: Write implementation for action
		} // MssPostRequest

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssKey"></param>
		/// <param name="ssProductId"></param>
		/// <param name="ssProductName"></param>
		/// <param name="ssResult"></param>
		/// <param name="ssReason">Only set when Result is false.
		/// It returns the reason why the oml/xif/osp cannot be uploaded</param>
		public void MssActivationCanUploadAndPublish(string ssKey, string ssProductId, string ssProductName, out bool ssResult, out RCHEMessageRecord ssReason) {
			ssResult = false;
			ssReason = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssActivationCanUploadAndPublish

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProductLicense"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationUploadProductLicense(byte[] ssProductLicense, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationUploadProductLicense

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEncryptedRequest"></param>
		/// <param name="ssEncryptedResponse"></param>
		public void MssActivationCanOpenOml(string ssEncryptedRequest, out string ssEncryptedResponse) {
			ssEncryptedResponse = "";
			// TODO: Write implementation for action
		} // MssActivationCanOpenOml

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOml"></param>
		/// <param name="ssEspaceId"></param>
		public void MssActivationUpdateEspaceProductInfo(byte[] ssOml, int ssEspaceId) {
			// TODO: Write implementation for action
		} // MssActivationUpdateEspaceProductInfo

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssLicenseBinary"></param>
		/// <param name="ssType">The result is one of:
		/// PlatformLicense
		/// ProductLicense
		/// Unknown</param>
		public void MssActivationGetLicenseType(byte[] ssLicenseBinary, out string ssType) {
			ssType = "";
			// TODO: Write implementation for action
		} // MssActivationGetLicenseType

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationGetFeatureVisibility(string ssFeatureId, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetFeatureVisibility

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProductId"></param>
		/// <param name="ssIsOpenSource"></param>
		public void MssActivationIsProductLicenseOpenSource(string ssProductId, out bool ssIsOpenSource) {
			ssIsOpenSource = false;
			// TODO: Write implementation for action
		} // MssActivationIsProductLicenseOpenSource

		/// <summary>
		/// Returns the string representation of the &apos;Value&apos; in the specified &apos;Locale&apos;.
		/// &apos;Type&apos; should be &quot;N&quot; to format the &apos;Value&apos; as a decimal, or &quot;C&quot; to format the &apos;Value&apos; as a currency.
		/// </summary>
		/// <param name="ssValue"></param>
		/// <param name="ssType">&quot;N&quot; - decimal; &quot;C&quot; - currency</param>
		/// <param name="ssLocale"></param>
		/// <param name="ssFormattedValue"></param>
		public void MssFormatNumberToLocale(decimal ssValue, string ssType, string ssLocale, out string ssFormattedValue) {
			ssFormattedValue = "";
			// TODO: Write implementation for action
		} // MssFormatNumberToLocale

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssLocaleList"></param>
		public void MssGetSupportedLocales(out RLKeyValuePairRecordList ssLocaleList) {
			ssLocaleList = new RLKeyValuePairRecordList();
			// TODO: Write implementation for action
		} // MssGetSupportedLocales

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationRefreshStateAsync(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationRefreshStateAsync

		/// <summary>
		/// Provides access to the MaxDate function (which, while inside the BuitinFunction class, is not actually exposed to SS)
		/// </summary>
		/// <param name="ssMaxDate"></param>
		public void MssGetMaxDate(out DateTime ssMaxDate) {
			ssMaxDate = new DateTime(1900, 1, 1, 0, 0, 0);
			// TODO: Write implementation for action
		} // MssGetMaxDate

		/// <summary>
		/// Checks if a refresh is being performed in the node&apos;s Deploy Service. If no IP is provided, the local node is checked.
		/// </summary>
		/// <param name="ssip"></param>
		/// <param name="ssresult"></param>
		public void MssRefreshingInProgress(string ssip, out bool ssresult) {
			ssresult = false;
			// TODO: Write implementation for action
		} // MssRefreshingInProgress

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sscode"></param>
		public void MssSetReturnStatus(int sscode) {
			// TODO: Write implementation for action
		} // MssSetReturnStatus

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationCanUseCloudServicesAPI(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationCanUseCloudServicesAPI

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssName"></param>
		/// <param name="ssValidName"></param>
		public void MssCorrectServiceCenterUsername(string ssName, out string ssValidName) {
			ssValidName = "";
			// TODO: Write implementation for action
		} // MssCorrectServiceCenterUsername

		/// <summary>
		/// Used only for upgrades: the Application table no longer has the SolutionId attribute, so in SC we can&apos;t query it
		/// </summary>
		/// <param name="ssApplicationId"></param>
		/// <param name="ssSolutionId"></param>
		public void MssGetApplicationSolutionId(int ssApplicationId, out int ssSolutionId) {
			ssSolutionId = 0;
			// TODO: Write implementation for action
		} // MssGetApplicationSolutionId

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssData"></param>
		/// <param name="ssHash"></param>
		public void MssGetHash(byte[] ssData, out string ssHash) {
			ssHash = "";
			// TODO: Write implementation for action
		} // MssGetHash

		/// <summary>
		/// 
		/// </summary>
		public void MssActivationResetState() {
			// TODO: Write implementation for action
		} // MssActivationResetState

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPassword"></param>
		/// <param name="ssTargetServerVersion"></param>
		/// <param name="ssEncryptedPassword"></param>
		public void MssAuthentication_EncryptPasswordForWebServiceRequest(string ssPassword, string ssTargetServerVersion, out string ssEncryptedPassword) {
			ssEncryptedPassword = "";
			// TODO: Write implementation for action
		} // MssAuthentication_EncryptPasswordForWebServiceRequest

		/// <summary>
		/// Returns the name of the physical page that corresponds to the current screen. It is usualy the same as the screen name, except when nameclashes occur.
		/// </summary>
		/// <param name="ssPageName">Name of the physical page that corresponds to the current screen.</param>
		public void MssGetPageName(out string ssPageName) {
			ssPageName = "";
			// TODO: Write implementation for action
		} // MssGetPageName

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssMessages"></param>
		public void MssPrepareEspaceCompilationWorkspace(string ssEspaceName, int ssEspaceVersionId, string ssUniqueId, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssPrepareEspaceCompilationWorkspace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssMessages"></param>
		public void MssDeleteEspaceCompilationWorkspace(string ssEspaceName, string ssUniqueId, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDeleteEspaceCompilationWorkspace

		/// <summary>
		/// Validates  the Version of the running (current) ServiceCenter against the PlatformServerVersion argument. In practice this looks at the version of the OMLProcessor and checks it against PlatformServerVersion.
		/// </summary>
		/// <param name="ssPlatformServerVersion"></param>
		/// <param name="ssValid"></param>
		/// <param name="ssErrMessage"></param>
		public void MssValidateRunningServiceCenterVersion(string ssPlatformServerVersion, out bool ssValid, out RCHEMessageRecord ssErrMessage) {
			ssValid = false;
			ssErrMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssValidateRunningServiceCenterVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPlatformServerVersion"></param>
		/// <param name="ssValid"></param>
		/// <param name="ssErrMessage"></param>
		public void MssValidateControllerBinariesVersion(string ssPlatformServerVersion, out bool ssValid, out RCHEMessageRecord ssErrMessage) {
			ssValid = false;
			ssErrMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssValidateControllerBinariesVersion

		/// <summary>
		/// This will log the message to the error log...
		/// </summary>
		/// <param name="ssMessage"></param>
		/// <param name="ssModuleName"></param>
		public void MssLogApplicationError(string ssMessage, string ssModuleName) {
			// TODO: Write implementation for action
		} // MssLogApplicationError

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssTableName">Event table name</param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssProcessIds"></param>
		public void MssGetProcessIdsFromEventTable(string ssTableName, int ssEspaceId, out RLEntityEventRecordList ssProcessIds) {
			ssProcessIds = new RLEntityEventRecordList();
			// TODO: Write implementation for action
		} // MssGetProcessIdsFromEventTable

		/// <summary>
		/// Delete an event from an entity event table based on the ProcessId
		/// </summary>
		/// <param name="ssTableName"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssSuccess"></param>
		public void MssDeleteEventFromEventTable(string ssTableName, int ssProcessId, int ssEspaceId, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssDeleteEventFromEventTable

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssResponse"></param>
		public void MssActivationGetFailoverState(out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationGetFailoverState

		/// <summary>
		/// Checks if the given application is a read-only application.
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssIsReadOnly"></param>
		public void MssIsReadOnlyApplication(string ssApplicationKey, out bool ssIsReadOnly) {
			ssIsReadOnly = false;
			// TODO: Write implementation for action
		} // MssIsReadOnlyApplication

		/// <summary>
		/// Checks if the given application is a read-only application.
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssIsSystem"></param>
		public void MssIsSystemApplication(string ssApplicationKey, out bool ssIsSystem) {
			ssIsSystem = false;
			// TODO: Write implementation for action
		} // MssIsSystemApplication

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssVersionId"></param>
		/// <param name="ssDeveloperId"></param>
		/// <param name="ssFromSolutionPublish">When publishing from a solution, the SU/AO conumption will not be done (it will have been done before in the previous steps of solution publish)</param>
		/// <param name="ssMessages"></param>
		public void MssPublishExtension_SwitchPublishedVersion(int ssVersionId, int ssDeveloperId, bool ssFromSolutionPublish, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssPublishExtension_SwitchPublishedVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssExtensionId"></param>
		/// <param name="ssActions"></param>
		/// <param name="ssStructures"></param>
		/// <param name="ssExtensionEntities"></param>
		public void MssGetExtensionPublicElements(int ssExtensionId, out RLActionInfoRecordList ssActions, out RLStructureInfoRecordList ssStructures, out RLExtensionEntityInfoRecordList ssExtensionEntities) {
			ssActions = new RLActionInfoRecordList();
			ssStructures = new RLStructureInfoRecordList();
			ssExtensionEntities = new RLExtensionEntityInfoRecordList();
			// TODO: Write implementation for action
		} // MssGetExtensionPublicElements

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssResult"></param>
		public void MssActivationCanUsePlatformFeature_Cached(string ssFeatureId, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssActivationCanUsePlatformFeature_Cached

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		public void MssActivationCheckPlatformFeature_Cached(string ssFeatureId) {
			// TODO: Write implementation for action
		} // MssActivationCheckPlatformFeature_Cached

		/// <summary>
		/// Checks if the given module is a system module.
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssIsSystem"></param>
		public void MssIsSystemModule(string ssModuleKey, out bool ssIsSystem) {
			ssIsSystem = false;
			// TODO: Write implementation for action
		} // MssIsSystemModule

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOk"></param>
		public void MssCanUseExternalAuthenticationProvider(out bool ssOk) {
			ssOk = false;
			// TODO: Write implementation for action
		} // MssCanUseExternalAuthenticationProvider

		/// <summary>
		/// Returns the Company Name to be used in branding purposes.
		/// default value is &quot;OutSystems&quot;
		/// </summary>
		/// <param name="ssCompanyName"></param>
		public void MssGetCompanyName(out string ssCompanyName) {
			ssCompanyName = "";
			// TODO: Write implementation for action
		} // MssGetCompanyName

		/// <summary>
		/// Returns the Platform Name to be used in branding purposes.
		/// default value is &quot;Platform&quot;
		/// </summary>
		/// <param name="ssPlatformName"></param>
		public void MssGetPlatformName(out string ssPlatformName) {
			ssPlatformName = "";
			// TODO: Write implementation for action
		} // MssGetPlatformName

		/// <summary>
		/// Returns if the installation is in WhiteLabeling
		/// </summary>
		/// <param name="ssIsWhiteLabeling">Returns if It&apos;s in a WhiteLabeling Installation</param>
		public void MssIsWhiteLabeling(out bool ssIsWhiteLabeling) {
			ssIsWhiteLabeling = false;
			// TODO: Write implementation for action
		} // MssIsWhiteLabeling

		/// <summary>
		/// Returns the path to the devops tools images to be used for branding purposes.
		/// Default value is the current directory.
		/// </summary>
		/// <param name="ssDevOpsToolsImagesPath"></param>
		public void MssGetDevOpsToolsImagesPath(out string ssDevOpsToolsImagesPath) {
			ssDevOpsToolsImagesPath = "";
			// TODO: Write implementation for action
		} // MssGetDevOpsToolsImagesPath

		/// <summary>
		/// Returns the text to replace the submit feedback, on the whitelabeling context.
		/// 
		/// </summary>
		/// <param name="ssErrorInformation"></param>
		public void MssGetDevOpsGeneralErrorInformation(out string ssErrorInformation) {
			ssErrorInformation = "";
			// TODO: Write implementation for action
		} // MssGetDevOpsGeneralErrorInformation

		/// <summary>
		/// Returns the Allow Silent Notifications parameter to be used in branding purposes.
		/// default value is &quot;true&quot;
		/// </summary>
		/// <param name="ssAllowSilentNotifications"></param>
		public void MssGetAllowSilentNotifications(out bool ssAllowSilentNotifications) {
			ssAllowSilentNotifications = false;
			// TODO: Write implementation for action
		} // MssGetAllowSilentNotifications

		/// <summary>
		/// Get Brand Company and Platform Name, combining the CompanyName and PlatformName from Labeling resources
		/// </summary>
		/// <param name="ssCompanyOnly"></param>
		/// <param name="ssBrand"></param>
		public void MssGetBrandCompanyAndPlatform(bool ssCompanyOnly, out string ssBrand) {
			ssBrand = "";
			// TODO: Write implementation for action
		} // MssGetBrandCompanyAndPlatform

		/// <summary>
		/// Returns the help base url to be used in a white labeling installation
		/// </summary>
		/// <param name="ssHelpBaseUrl"></param>
		public void MssGetHelpBaseUrl(out string ssHelpBaseUrl) {
			ssHelpBaseUrl = "";
			// TODO: Write implementation for action
		} // MssGetHelpBaseUrl

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssIs1CPFromSS"></param>
		/// <param name="ssespaceKey"></param>
		/// <param name="sspublishStep"></param>
		/// <param name="ssparentStep"></param>
		/// <param name="ssextraInfo"></param>
		public void MssOSTracePublishTimerStart(string ssOperationId, bool ssIs1CPFromSS, string ssespaceKey, string sspublishStep, string ssparentStep, string ssextraInfo) {
			// TODO: Write implementation for action
		} // MssOSTracePublishTimerStart

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssIs1CPFromSS"></param>
		/// <param name="ssespaceKey"></param>
		/// <param name="sspublishStep"></param>
		/// <param name="ssparentStep"></param>
		/// <param name="ssextraInfo"></param>
		public void MssOSTracePublishTimerEnd(string ssOperationId, bool ssIs1CPFromSS, string ssespaceKey, string sspublishStep, string ssparentStep, string ssextraInfo) {
			// TODO: Write implementation for action
		} // MssOSTracePublishTimerEnd

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssESpaceKey"></param>
		/// <param name="ssPendingVersionId"></param>
		/// <param name="ssPendingName"></param>
		public void MssSetEspacePendingVersion(string ssESpaceKey, int ssPendingVersionId, string ssPendingName) {
			// TODO: Write implementation for action
		} // MssSetEspacePendingVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssESpaceKey"></param>
		/// <param name="ssNewName"></param>
		public void MssChangeEspaceName(string ssESpaceKey, string ssNewName) {
			// TODO: Write implementation for action
		} // MssChangeEspaceName

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEnumType"></param>
		/// <param name="ssEnumValues"></param>
		public void MssDALDBConfigEnumValues(string ssEnumType, out RLDALDBConfigEnumValueRecordList ssEnumValues) {
			ssEnumValues = new RLDALDBConfigEnumValueRecordList();
			// TODO: Write implementation for action
		} // MssDALDBConfigEnumValues

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProviders"></param>
		public void MssDALDBConfigGetProviders(out RLDALDBConfigProviderRecordList ssProviders) {
			ssProviders = new RLDALDBConfigProviderRecordList();
			// TODO: Write implementation for action
		} // MssDALDBConfigGetProviders

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDBConfig"></param>
		/// <param name="ssParams"></param>
		public void MssDALDBConfigSetParams(object ssDBConfig, RLDALDBConfigParamRecordList ssParams) {
			// TODO: Write implementation for action
		} // MssDALDBConfigSetParams

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDBConfig"></param>
		/// <param name="ssParams"></param>
		public void MssDALDBConfigGetParams(object ssDBConfig, out RLDALDBConfigParamRecordList ssParams) {
			ssParams = new RLDALDBConfigParamRecordList();
			// TODO: Write implementation for action
		} // MssDALDBConfigGetParams

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDBConfig"></param>
		/// <param name="ssProvider"></param>
		public void MssDALDBConfigGetProvider(object ssDBConfig, out RCDALDBConfigProviderRecord ssProvider) {
			ssProvider = new RCDALDBConfigProviderRecord(null);
			// TODO: Write implementation for action
		} // MssDALDBConfigGetProvider

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssProviderKey"></param>
		/// <param name="ssAdvanced"></param>
		/// <param name="ssDBConfig"></param>
		public void MssDALDBConfigCreate(string ssProviderKey, bool ssAdvanced, out object ssDBConfig) {
			ssDBConfig = null;
			// TODO: Write implementation for action
		} // MssDALDBConfigCreate

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDBConfig"></param>
		/// <param name="ssSerializedForm"></param>
		public void MssDALDBConfigSerialize(object ssDBConfig, out string ssSerializedForm) {
			ssSerializedForm = "";
			// TODO: Write implementation for action
		} // MssDALDBConfigSerialize

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSerializedForm"></param>
		/// <param name="ssDBConfig"></param>
		public void MssDALDBConfigDeserialize(string ssSerializedForm, out object ssDBConfig) {
			ssDBConfig = null;
			// TODO: Write implementation for action
		} // MssDALDBConfigDeserialize

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDbmsName"></param>
		/// <param name="ssConnStr"></param>
		/// <param name="ssUpgradedConnStr"></param>
		public void MssDALDBConfigUpgrade(string ssDbmsName, string ssConnStr, out string ssUpgradedConnStr) {
			ssUpgradedConnStr = "";
			// TODO: Write implementation for action
		} // MssDALDBConfigUpgrade

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSerializedForm"></param>
		/// <param name="ssProviderName"></param>
		public void MssDALDBConfigGetProviderName(string ssSerializedForm, out string ssProviderName) {
			ssProviderName = "";
			// TODO: Write implementation for action
		} // MssDALDBConfigGetProviderName

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssRuntimeLogin"></param>
		public void MssDBCatalogGetRuntimeLogin(out string ssRuntimeLogin) {
			ssRuntimeLogin = "";
			// TODO: Write implementation for action
		} // MssDBCatalogGetRuntimeLogin

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssEntitiesDBProviderKeys"></param>
		public void MssGetEntitiesDBProviderKeys(string ssEspaceKey, out RLEntityDBProviderKeyRecordList ssEntitiesDBProviderKeys) {
			ssEntitiesDBProviderKeys = new RLEntityDBProviderKeyRecordList();
			// TODO: Write implementation for action
		} // MssGetEntitiesDBProviderKeys

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleKeys"></param>
		/// <param name="ssHighlightingHashesForEntities"></param>
		/// <param name="ssHighlightingHashForCurrentDatabase"></param>
		/// <param name="ssHighlightingHashForANSIDB"></param>
		public void MssDALGetHighlightingHashesForEntities(RLTextRecordList ssModuleKeys, out RLDALEntityHighlightingHashRecordList ssHighlightingHashesForEntities, out string ssHighlightingHashForCurrentDatabase, out string ssHighlightingHashForANSIDB) {
			ssHighlightingHashesForEntities = new RLDALEntityHighlightingHashRecordList();
			ssHighlightingHashForCurrentDatabase = "";
			ssHighlightingHashForANSIDB = "";
			// TODO: Write implementation for action
		} // MssDALGetHighlightingHashesForEntities

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssHashes"></param>
		/// <param name="ssHighlightingResources"></param>
		public void MssDALGetHighlightingDefinitions(RLTextRecordList ssHashes, out RLDALHighlightingDefinitionRecordList ssHighlightingResources) {
			ssHighlightingResources = new RLDALHighlightingDefinitionRecordList();
			// TODO: Write implementation for action
		} // MssDALGetHighlightingDefinitions

		/// <summary>
		/// 
		/// </summary>
		public void MssDALInvalidateHighlightingHashes() {
			// TODO: Write implementation for action
		} // MssDALInvalidateHighlightingHashes

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceId"></param>
		public void MssDropInactiveEntitiesForeignKeys(int ssEspaceId) {
			// TODO: Write implementation for action
		} // MssDropInactiveEntitiesForeignKeys

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssInactiveEntityList"></param>
		public void MssEntity_ListDeleted(out RLEntityDefinitionRecordList ssInactiveEntityList) {
			ssInactiveEntityList = new RLEntityDefinitionRecordList();
			// TODO: Write implementation for action
		} // MssEntity_ListDeleted

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssInactiveAttributeList"></param>
		public void MssAttribute_ListDeleted(out RLAttributeDefinitionRecordList ssInactiveAttributeList) {
			ssInactiveAttributeList = new RLAttributeDefinitionRecordList();
			// TODO: Write implementation for action
		} // MssAttribute_ListDeleted

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEntityId"></param>
		/// <param name="ssSuccess"></param>
		public void MssEntity_DropTable(int ssEntityId, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssEntity_DropTable

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssAttributeId"></param>
		/// <param name="ssSuccess"></param>
		public void MssAttribute_DropColumn(int ssAttributeId, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssAttribute_DropColumn

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOlderThan"></param>
		/// <param name="ssModuleName"></param>
		/// <param name="ssModuleType"></param>
		/// <param name="ssMaxNumberOfVersions"></param>
		/// <param name="ssModuleVersionList"></param>
		/// <param name="ssHasMoreVersions"></param>
		public void MssModuleVersion_ListOldest(DateTime ssOlderThan, string ssModuleName, string ssModuleType, int ssMaxNumberOfVersions, out RLModuleVersionDefinitionRecordList ssModuleVersionList, out bool ssHasMoreVersions) {
			ssModuleVersionList = new RLModuleVersionDefinitionRecordList();
			ssHasMoreVersions = false;
			// TODO: Write implementation for action
		} // MssModuleVersion_ListOldest

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOlderThan"></param>
		/// <param name="ssModuleId"></param>
		/// <param name="ssMaxNumberOfVersions"></param>
		/// <param name="ssHasMoreVersions"></param>
		public void MssModuleVersion_DeleteAll(DateTime ssOlderThan, int ssModuleId, int ssMaxNumberOfVersions, out bool ssHasMoreVersions) {
			ssHasMoreVersions = false;
			// TODO: Write implementation for action
		} // MssModuleVersion_DeleteAll

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleVersionId"></param>
		/// <param name="ssModuleId"></param>
		public void MssModuleVersion_Delete(int ssModuleVersionId, int ssModuleId) {
			// TODO: Write implementation for action
		} // MssModuleVersion_Delete

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssVersionId"></param>
		/// <param name="ssModuleKindId"></param>
		/// <param name="ssAllVersions"></param>
		public void MssModule_DeletePublicElementsFromVersion(int ssVersionId, int ssModuleKindId, bool ssAllVersions) {
			// TODO: Write implementation for action
		} // MssModule_DeletePublicElementsFromVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPassword"></param>
		/// <param name="ssAlgorithmIndex">Set AlgorithmIndex to -1 to use the best algorithm available</param>
		/// <param name="ssHash"></param>
		public void MssAuthentication_GeneratePassHashBasedOnSettings(string ssPassword, int ssAlgorithmIndex, out string ssHash) {
			ssHash = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GeneratePassHashBasedOnSettings

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPassword"></param>
		/// <param name="ssHash"></param>
		/// <param name="ssValid"></param>
		public void MssAuthentication_ValidatePasswordHash(string ssPassword, string ssHash, out bool ssValid) {
			ssValid = false;
			// TODO: Write implementation for action
		} // MssAuthentication_ValidatePasswordHash

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssWebServicePassword"></param>
		/// <param name="ssHash"></param>
		/// <param name="ssValid"></param>
		public void MssAuthentication_ValidateWebServicePassword(string ssWebServicePassword, string ssHash, out bool ssValid) {
			ssValid = false;
			// TODO: Write implementation for action
		} // MssAuthentication_ValidateWebServicePassword

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPasswordFromWebServiceRequest"></param>
		/// <param name="ssAlgorithmIndex">Set AlgorithmIndex to -1 to use the best algorithm available </param>
		/// <param name="ssHash"></param>
		public void MssAuthentication_GeneratePassHashFromWServiceRequest(string ssPasswordFromWebServiceRequest, int ssAlgorithmIndex, out string ssHash) {
			ssHash = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GeneratePassHashFromWServiceRequest

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPasswordHash"></param>
		/// <param name="ssAlgorithmIndex"></param>
		public void MssAuthentication_GetAlgorithmIndexForPasswordHash(string ssPasswordHash, out int ssAlgorithmIndex) {
			ssAlgorithmIndex = 0;
			// TODO: Write implementation for action
		} // MssAuthentication_GetAlgorithmIndexForPasswordHash

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssValue"></param>
		/// <param name="ssResult"></param>
		public void MssMD5Hash(string ssValue, out string ssResult) {
			ssResult = "";
			// TODO: Write implementation for action
		} // MssMD5Hash

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEncryptedValue"></param>
		public void MssAuthentication_GetForceSecureAlgorithmsEncrypted(out string ssEncryptedValue) {
			ssEncryptedValue = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GetForceSecureAlgorithmsEncrypted

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDecryptedURL"></param>
		/// <param name="ssEncryptedURL"></param>
		public void MssEncryptMetricsURL(string ssDecryptedURL, out string ssEncryptedURL) {
			ssEncryptedURL = "";
			// TODO: Write implementation for action
		} // MssEncryptMetricsURL

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssBestHashingAlgorithm"></param>
		public void MssAuthentication_GetBestHashingAlgorithm(out int ssBestHashingAlgorithm) {
			ssBestHashingAlgorithm = 0;
			// TODO: Write implementation for action
		} // MssAuthentication_GetBestHashingAlgorithm

		/// <summary>
		/// Gives the plug-in&apos;s supported properties. Check the Service Center&apos;s Authentication_Supported_Properties static entity to know the options.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssSupportedProperties">The supported properties. Must be contained in the Service Center&apos;s Authentication_Suported_Properties static entities.</param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		public void MssExternalAuthentication_GetProperties(string ssWsURL, out RLKeyValuePairRecordList ssSupportedProperties, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus) {
			ssSupportedProperties = new RLKeyValuePairRecordList();
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			// TODO: Write implementation for action
		} // MssExternalAuthentication_GetProperties

		/// <summary>
		/// Validates that the given user can login into the Platform. Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssUsername">The username of the user to validate.</param>
		/// <param name="ssUserPoolGuid">The user pool guid that is validating the user.</param>
		/// <param name="ssUserId">The (plaftorm&apos;s) id of the user.</param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		public void MssExternalAuthentication_ValidateUser(string ssWsURL, string ssUsername, string ssUserPoolGuid, out int ssUserId, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus) {
			ssUserId = 0;
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			// TODO: Write implementation for action
		} // MssExternalAuthentication_ValidateUser

		/// <summary>
		/// Activates the plug-in. The plug-in can refuse to be activated. Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		public void MssExternalAuthentication_Activate(string ssWsURL, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus) {
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			// TODO: Write implementation for action
		} // MssExternalAuthentication_Activate

		/// <summary>
		/// Deactivates the plug-in. The plug-in cannot refuse to be deactivated. Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		public void MssExternalAuthentication_Deactivate(string ssWsURL) {
			// TODO: Write implementation for action
		} // MssExternalAuthentication_Deactivate

		/// <summary>
		/// Tests the plug-in. Very important to do before any activation request. Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		public void MssExternalAuthentication_Test(string ssWsURL, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus) {
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			// TODO: Write implementation for action
		} // MssExternalAuthentication_Test

		/// <summary>
		/// Validates that the given user can login into the Platform. Acts like a proxy to the corresponding web service operation provided by an external authentication plugin. Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssUsername">The username of the user to validate.</param>
		/// <param name="ssPassword">The user&apos;s password.</param>
		/// <param name="ssEncodedPassword">When using custom authentication SS sends an encoded password that can be decrypted by the server. This parameter is for that version of the password.</param>
		/// <param name="ssUserPoolGuid">The user pool guid that is validating the user.</param>
		/// <param name="ssUserId">The (plaftorm&apos;s) id of the user.</param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		public void MssExternalAuthentication_ValidateUserCredentials(string ssWsURL, string ssUsername, string ssPassword, string ssEncodedPassword, string ssUserPoolGuid, out int ssUserId, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus) {
			ssUserId = 0;
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			// TODO: Write implementation for action
		} // MssExternalAuthentication_ValidateUserCredentials

		/// <summary>
		/// A wrapper around IntegratedSecurityGetDetails, as the build-in function does not work on ServiceCenter. This should be revisited sometime in the future.
		/// </summary>
		/// <param name="ssUsername">The user identified by the integrated authentication. Includes the domain.</param>
		/// <param name="ssIsGuest">Is it a guest user?</param>
		/// <param name="ssIsSystem">Is it a system user?</param>
		/// <param name="ssIsAnonymous">Is it anonymous?</param>
		/// <param name="ssIsAuthenticated">Is it an authenticated user?</param>
		public void MssExternalAuthentication_GetIntegratedAuthUser(out string ssUsername, out bool ssIsGuest, out bool ssIsSystem, out bool ssIsAnonymous, out bool ssIsAuthenticated) {
			ssUsername = "";
			ssIsGuest = false;
			ssIsSystem = false;
			ssIsAnonymous = false;
			ssIsAuthenticated = false;
			// TODO: Write implementation for action
		} // MssExternalAuthentication_GetIntegratedAuthUser

		/// <summary>
		/// Validates that a given WSDL complies with the External Authentication Plug-in API&apos;s contract.
		/// </summary>
		/// <param name="ssWsdl">The WSDL to validate.</param>
		/// <param name="ssSuccess">Whether the WSDL complies with the contract.</param>
		/// <param name="ssErrorMessage">Detailed info if the WSDL does not comply with the contract.</param>
		public void MssExternalAuthentication_ValidatePluginApiContract(string ssWsdl, out bool ssSuccess, out string ssErrorMessage) {
			ssSuccess = false;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssExternalAuthentication_ValidatePluginApiContract

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssintegrations"></param>
		public void MssGetAvailableIntegrations(out RLIntegrationPluginInfoRecordList ssintegrations) {
			ssintegrations = new RLIntegrationPluginInfoRecordList();
			// TODO: Write implementation for action
		} // MssGetAvailableIntegrations

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssXIF"></param>
		/// <param name="ssXIFEntities"></param>
		public void MssGetEntitiesInfoFromXIF(byte[] ssXIF, out RLExtensionEntityInfoRecordList ssXIFEntities) {
			ssXIFEntities = new RLExtensionEntityInfoRecordList();
			// TODO: Write implementation for action
		} // MssGetEntitiesInfoFromXIF

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssURL"></param>
		/// <param name="ssContentType"></param>
		/// <param name="ssBody"></param>
		/// <param name="ssResponse"></param>
		public void MssPostURL(string ssURL, string ssContentType, string ssBody, out string ssResponse) {
			ssResponse = "";
			// TODO: Write implementation for action
		} // MssPostURL

		/// <summary>
		/// Creates a zip file from a collection of Files
		/// </summary>
		/// <param name="ssZipFile"></param>
		/// <param name="ssFiles"></param>
		public void MssCreateZip(out byte[] ssZipFile, RLFileRecordList ssFiles) {
			ssZipFile = new byte[] {};
			// TODO: Write implementation for action
		} // MssCreateZip

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssApplicationServer"></param>
		/// <param name="ssVersion"></param>
		public void MssStackInfo_ApplicationServerAndVersion(out string ssApplicationServer, out string ssVersion) {
			ssApplicationServer = "";
			ssVersion = "";
			// TODO: Write implementation for action
		} // MssStackInfo_ApplicationServerAndVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDatabaseProvider"></param>
		/// <param name="ssVersion"></param>
		public void MssStackInfo_DatabaseProviderAndVersion(out string ssDatabaseProvider, out string ssVersion) {
			ssDatabaseProvider = "";
			ssVersion = "";
			// TODO: Write implementation for action
		} // MssStackInfo_DatabaseProviderAndVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssRuntime"></param>
		/// <param name="ssVersion"></param>
		public void MssStackInfo_RuntimeAndVersion(out string ssRuntime, out string ssVersion) {
			ssRuntime = "";
			ssVersion = "";
			// TODO: Write implementation for action
		} // MssStackInfo_RuntimeAndVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperatingSystem"></param>
		/// <param name="ssVersion"></param>
		public void MssStackInfo_OperatingSystemAndVersion(out string ssOperatingSystem, out string ssVersion) {
			ssOperatingSystem = "";
			ssVersion = "";
			// TODO: Write implementation for action
		} // MssStackInfo_OperatingSystemAndVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssValue"></param>
		/// <param name="ssHMAC"></param>
		public void MssCalculateHMAC(string ssValue, out string ssHMAC) {
			ssHMAC = "";
			// TODO: Write implementation for action
		} // MssCalculateHMAC

		/// <summary>
		/// This operation is used to consume the given number of units from the license.
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssUnits"></param>
		/// <param name="ssVersion"></param>
		/// <param name="ssResponse"></param>
		public void MssActivationDoConsumeUnits(string ssModuleKey, int ssUnits, int ssVersion, out RCActivationResponseRecord ssResponse) {
			ssResponse = new RCActivationResponseRecord(null);
			// TODO: Write implementation for action
		} // MssActivationDoConsumeUnits

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssExtensionVersionId">Extension Version Identifier</param>
		/// <param name="ssHMAC">HMAC to validate</param>
		/// <param name="ssIsValid"></param>
		public void MssActivationValidateExtensionVersionHmac(int ssExtensionVersionId, string ssHMAC, out bool ssIsValid) {
			ssIsValid = false;
			// TODO: Write implementation for action
		} // MssActivationValidateExtensionVersionHmac

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssModules"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssContinueOnError"></param>
		/// <param name="ssDeploymentDetails"></param>
		/// <param name="ssApplicationsDetails"></param>
		/// <param name="ssMessages"></param>
		public void MssSolutionUpdateDBSecondStage(string ssOperationId, RLReferenceRecordList ssModules, string ssUniqueId, string ssUsername, bool ssContinueOnError, RLDeploymentDetailsRecordList ssDeploymentDetails, RLApplicationModuleDetailsRecordList ssApplicationsDetails, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssSolutionUpdateDBSecondStage

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssName">Name of the header.</param>
		/// <param name="ssValue">Value of the header.</param>
		public void MssAddHeader(string ssName, string ssValue) {
			// TODO: Write implementation for action
		} // MssAddHeader

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssName"></param>
		/// <param name="ssContent"></param>
		public void MssAddMetaTag(string ssName, string ssContent) {
			// TODO: Write implementation for action
		} // MssAddMetaTag

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssKey"></param>
		/// <param name="ssLicensedUnits"></param>
		public void MssActivationGetLicensedUnitsForComponent(string ssKey, out int ssLicensedUnits) {
			ssLicensedUnits = 0;
			// TODO: Write implementation for action
		} // MssActivationGetLicensedUnitsForComponent

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssURL"></param>
		/// <param name="ssContent"></param>
		public void MssGetURLBinary(string ssURL, out byte[] ssContent) {
			ssContent = new byte[] {};
			// TODO: Write implementation for action
		} // MssGetURLBinary

		/// <summary>
		/// Creates a zip file containing all the application resources that are included in its manifest
		/// </summary>
		/// <param name="ssZipFile"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssEntryEspaceKey"></param>
		public void MssGetApplicationResourcesZip(out byte[] ssZipFile, string ssApplicationKey, string ssEntryEspaceKey) {
			ssZipFile = new byte[] {};
			// TODO: Write implementation for action
		} // MssGetApplicationResourcesZip

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssImage"></param>
		/// <param name="ssNewWidth"></param>
		/// <param name="ssNewHeight"></param>
		/// <param name="ssResizeImage"></param>
		public void MssImageResize(byte[] ssImage, int ssNewWidth, int ssNewHeight, out byte[] ssResizeImage) {
			ssResizeImage = new byte[] {};
			// TODO: Write implementation for action
		} // MssImageResize

		/// <summary>
		/// Ensures login bruteforce protection mechanisms.
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssIPAddress"></param>
		/// <param name="ssIsBruteForceAttempt"></param>
		/// <param name="ssLogMessage"></param>
		/// <param name="ssLoginAttempt"></param>
		/// <param name="ssLoginMessageCode"></param>
		/// <param name="ssLoginDeniedMessage"></param>
		public void MssCheckBruteForceAttempt(int ssUserId, string ssUsername, string ssIPAddress, out bool ssIsBruteForceAttempt, out string ssLogMessage, out RCLoginAttemptRecord ssLoginAttempt, out string ssLoginMessageCode, out string ssLoginDeniedMessage) {
			ssIsBruteForceAttempt = false;
			ssLogMessage = "";
			ssLoginAttempt = new RCLoginAttemptRecord(null);
			ssLoginMessageCode = "";
			ssLoginDeniedMessage = "";
			// TODO: Write implementation for action
		} // MssCheckBruteForceAttempt

		/// <summary>
		/// Stores a login attempt information record in the database. Used by login bruteforce protection mechanisms.
		/// </summary>
		/// <param name="ssLoginAttempt"></param>
		public void MssLogLoginAttempt(RCLoginAttemptRecord ssLoginAttempt) {
			// TODO: Write implementation for action
		} // MssLogLoginAttempt

		/// <summary>
		/// Returns the current request IP address.
		/// </summary>
		/// <param name="ssIPAddress"></param>
		public void MssGetRequestIPAddress(out string ssIPAddress) {
			ssIPAddress = "";
			// TODO: Write implementation for action
		} // MssGetRequestIPAddress

		/// <summary>
		/// Allows the specified user to be able to login in the specified IP address, finishing the user locking period.
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssIPAddress"></param>
		public void MssUser_Unlock(int ssUserId, string ssUsername, string ssIPAddress) {
			// TODO: Write implementation for action
		} // MssUser_Unlock

		/// <summary>
		/// Allows the specified user to be able to login in all IP addresses where the user was locked.
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssUsername"></param>
		public void MssUser_UnlockAll(int ssUserId, string ssUsername) {
			// TODO: Write implementation for action
		} // MssUser_UnlockAll

		/// <summary>
		/// Returns a list of last failed login attempts (one record for each IPaddress). This method returns enough information to invoke either user_unlock or IPaddress_unlock.
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssSince"></param>
		/// <param name="ssLoginAttempts"></param>
		public void MssUser_GetLastFailedLoginAttempts(int ssUserId, string ssUsername, DateTime ssSince, out RLLoginAttemptRecordList ssLoginAttempts) {
			ssLoginAttempts = new RLLoginAttemptRecordList();
			// TODO: Write implementation for action
		} // MssUser_GetLastFailedLoginAttempts

		/// <summary>
		/// Returns information regarding the locked/unlocked state of that user
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssIPAddress"></param>
		/// <param name="ssLoginAttempt"></param>
		public void MssUser_GetLockedStatus(int ssUserId, string ssUsername, string ssIPAddress, out RCLoginAttemptRecord ssLoginAttempt) {
			ssLoginAttempt = new RCLoginAttemptRecord(null);
			// TODO: Write implementation for action
		} // MssUser_GetLockedStatus

		/// <summary>
		/// Returns information regarding the locked/unlocked state of that IP address and the reason why the IP is locked
		/// </summary>
		/// <param name="ssIPAddress"></param>
		/// <param name="ssLoginAttempt"></param>
		public void MssIPAddress_GetLockedStatus(string ssIPAddress, out RCLoginAttemptRecord ssLoginAttempt) {
			ssLoginAttempt = new RCLoginAttemptRecord(null);
			// TODO: Write implementation for action
		} // MssIPAddress_GetLockedStatus

		/// <summary>
		/// Allows any user to be able to login in the specified IP address, finishing the IP locking period.
		/// </summary>
		/// <param name="ssIPAddress"></param>
		public void MssIPAddress_Unlock(string ssIPAddress) {
			// TODO: Write implementation for action
		} // MssIPAddress_Unlock

		/// <summary>
		/// Generates a strong password using a secure random FIPS compliant algorithm.
		/// </summary>
		/// <param name="ssSizeInBytes">The size of the generated password, in bytes.</param>
		/// <param name="ssPassword">Strong password in Base64.</param>
		public void MssGenerateStrongPassword(int ssSizeInBytes, out string ssPassword) {
			ssPassword = "";
			// TODO: Write implementation for action
		} // MssGenerateStrongPassword

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssParams"></param>
		/// <param name="ssModuleName"></param>
		/// <param name="ssMessage"></param>
		/// <param name="ssDetail"></param>
		public void MssLogCSPError(string ssParams, string ssModuleName, string ssMessage, string ssDetail) {
			// TODO: Write implementation for action
		} // MssLogCSPError

		/// <summary>
		/// Returns a list of locks that currently apply to the user. These might be (User, IP) locks or IP locks - check the Result field for more details. If there are no locks that apply to the user, the list will be empty.
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssLocks"></param>
		public void MssUser_GetLocks(int ssUserId, out RLLoginAttemptRecordList ssLocks) {
			ssLocks = new RLLoginAttemptRecordList();
			// TODO: Write implementation for action
		} // MssUser_GetLocks

		/// <summary>
		/// Returns a list of locks that currently apply to the IP. If there are no locks that apply to the IP, the list will be empty.
		/// </summary>
		/// <param name="ssIPAddress"></param>
		/// <param name="ssLocks"></param>
		public void MssIPAddress_GetLocks(string ssIPAddress, out RLLoginAttemptRecordList ssLocks) {
			ssLocks = new RLLoginAttemptRecordList();
			// TODO: Write implementation for action
		} // MssIPAddress_GetLocks

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssName"></param>
		/// <param name="ssResource"></param>
		public void MssGetEspaceResource(int ssEspaceVersionId, string ssName, out byte[] ssResource) {
			ssResource = new byte[] {};
			// TODO: Write implementation for action
		} // MssGetEspaceResource

		/// <summary>
		/// Validates if the provided list of IP addresses or ranges of addresses only contain the separators (;) and necessary characters to support IPv4 and IPv6 (numbers, letters and :).
		/// </summary>
		/// <param name="ssAddressesList">The list of IP addresses or ranges of addresses to validate.</param>
		/// <param name="ssIsValid"></param>
		public void MssValidateAddressSyntax(string ssAddressesList, out bool ssIsValid) {
			ssIsValid = false;
			// TODO: Write implementation for action
		} // MssValidateAddressSyntax

		/// <summary>
		/// Creates a zip file containing the Application Info file.
		/// </summary>
		/// <param name="ssZipFile"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssEntryEspaceKey"></param>
		public void MssGetApplicationInfoZip(out byte[] ssZipFile, string ssApplicationKey, string ssEntryEspaceKey) {
			ssZipFile = new byte[] {};
			// TODO: Write implementation for action
		} // MssGetApplicationInfoZip

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssJWTClaims"></param>
		/// <param name="ssToken"></param>
		public void MssJWTCreateToken(RCJWTClaimsRecord ssJWTClaims, out string ssToken) {
			ssToken = "";
			// TODO: Write implementation for action
		} // MssJWTCreateToken

		/// <summary>
		/// Validates the token validity and returns true if it is. The token is considered valid if signing the header and payload matches the received signature. If the token is valid the claims are returned.
		/// </summary>
		/// <param name="ssToken">The full token to validate, as received from the HTTPRequest</param>
		/// <param name="ssIsValid"></param>
		/// <param name="ssJWTClaims"></param>
		public void MssJWTValidate(string ssToken, out bool ssIsValid, out RCJWTClaimsRecord ssJWTClaims) {
			ssIsValid = false;
			ssJWTClaims = new RCJWTClaimsRecord(null);
			// TODO: Write implementation for action
		} // MssJWTValidate

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssNativizerURLToValidate"></param>
		public void MssNativeBuilderServiceBeforeRequest(string ssNativizerURLToValidate) {
			// TODO: Write implementation for action
		} // MssNativeBuilderServiceBeforeRequest

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSignedURL"></param>
		/// <param name="ssBinaryData"></param>
		/// <param name="ssContentType"></param>
		/// <param name="ssTimeout"></param>
		public void MssNativeBuilderUploadFile(string ssSignedURL, byte[] ssBinaryData, string ssContentType, int ssTimeout) {
			// TODO: Write implementation for action
		} // MssNativeBuilderUploadFile

		/// <summary>
		/// Extracts eSpace information from the OML header.
		/// NOTE: This API works with partial OMLs, because it uses only information available in the header, not fragments.
		/// </summary>
		/// <param name="ssOML"></param>
		/// <param name="sseSpace_name"></param>
		/// <param name="sseSpace_UID"></param>
		/// <param name="sseSpace_ServiceStudioVersion"></param>
		/// <param name="sseSpace_LastUpgradeVersion"></param>
		/// <param name="sseSpace_Description"></param>
		/// <param name="sseSpace_Hash"></param>
		/// <param name="sseSpace_LastModified"></param>
		/// <param name="ssActivationCode"></param>
		/// <param name="ssProductId"></param>
		/// <param name="ssProductName"></param>
		/// <param name="sseSpace_DirectUpgradeFrom"></param>
		/// <param name="sseSpace_GeneralHash"></param>
		/// <param name="sseSpace_IsTemplateBundle"></param>
		/// <param name="sseSpace_IsExcludedAO"></param>
		public void MssGetEspaceInfoFromOMLHeader(byte[] ssOML, out string sseSpace_name, out string sseSpace_UID, out string sseSpace_ServiceStudioVersion, out string sseSpace_LastUpgradeVersion, out string sseSpace_Description, out string sseSpace_Hash, out DateTime sseSpace_LastModified, out string ssActivationCode, out string ssProductId, out string ssProductName, out string sseSpace_DirectUpgradeFrom, out string sseSpace_GeneralHash, out bool sseSpace_IsTemplateBundle, out bool sseSpace_IsExcludedAO) {
			sseSpace_name = "";
			sseSpace_UID = "";
			sseSpace_ServiceStudioVersion = "";
			sseSpace_LastUpgradeVersion = "";
			sseSpace_Description = "";
			sseSpace_Hash = "";
			sseSpace_LastModified = new DateTime(1900, 1, 1, 0, 0, 0);
			ssActivationCode = "";
			ssProductId = "";
			ssProductName = "";
			sseSpace_DirectUpgradeFrom = "";
			sseSpace_GeneralHash = "";
			sseSpace_IsTemplateBundle = false;
			sseSpace_IsExcludedAO = false;
			// TODO: Write implementation for action
		} // MssGetEspaceInfoFromOMLHeader

		/// <summary>
		/// Lists all associations between mobile applications and native plugins
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssPluginModuleKey"></param>
		/// <param name="ssNativePluginConfigurations">Returns the list of Native plugin configurations that respect the input values&apos; restrictions</param>
		/// <param name="ssStatusCode"></param>
		/// <param name="ssErrorMessage">Detailed information about the error, when StatusCode &gt;= 400</param>
		public void MssNativePlugin_List(string ssApplicationKey, string ssPluginModuleKey, out RLNativePluginConfigurationRecordList ssNativePluginConfigurations, out int ssStatusCode, out string ssErrorMessage) {
			ssNativePluginConfigurations = new RLNativePluginConfigurationRecordList();
			ssStatusCode = 0;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssNativePlugin_List

		/// <summary>
		/// Registers a native plugin to be included when building a mobile application
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssPluginModuleKey"></param>
		/// <param name="ssStatusCode"></param>
		/// <param name="ssErrorMessage">Detailed information about the error, when StatusCode &gt;= 400</param>
		public void MssNativePlugin_Register(string ssApplicationKey, string ssPluginModuleKey, out int ssStatusCode, out string ssErrorMessage) {
			ssStatusCode = 0;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssNativePlugin_Register

		/// <summary>
		/// Unregisters a native plugin from being included when building a mobile application
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssPluginModuleKey"></param>
		/// <param name="ssStatusCode"></param>
		/// <param name="ssErrorMessage">Detailed information about the error, when StatusCode &gt;= 400</param>
		public void MssNativePlugin_Unregister(string ssApplicationKey, string ssPluginModuleKey, out int ssStatusCode, out string ssErrorMessage) {
			ssStatusCode = 0;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssNativePlugin_Unregister

		/// <summary>
		/// Updates the configuration hash for an application in a given device, e.g., Android.
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssDeviceTypeId"></param>
		/// <param name="ssDeviceTypeName"></param>
		public void MssUpdateConfigurationHash(string ssApplicationKey, int ssDeviceTypeId, string ssDeviceTypeName) {
			// TODO: Write implementation for action
		} // MssUpdateConfigurationHash

		/// <summary>
		/// Decrypts a binary in base 64 and converts it to a binary.
		/// </summary>
		/// <param name="ssData"></param>
		/// <param name="ssBinary"></param>
		public void MssDecryptBinary(string ssData, out RCBinaryDataRecord ssBinary) {
			ssBinary = new RCBinaryDataRecord(null);
			// TODO: Write implementation for action
		} // MssDecryptBinary

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssMessage">The message to add to the module general log.</param>
		/// <param name="ssModuleName">The name of the module to be associated with the log message.</param>
		public void MssLogStackTrace(string ssMessage, string ssModuleName) {
			// TODO: Write implementation for action
		} // MssLogStackTrace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssAppMobileConfigId"></param>
		/// <param name="ssMobilePlatformId"></param>
		/// <param name="ssRequesterUserId"></param>
		/// <param name="ssNativeHash"></param>
		/// <param name="ssSolutionPublishPlanId"></param>
		/// <param name="ssNativeBuildsEnabled"></param>
		/// <param name="ssUnavailableMobilePlatformsIds"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssResult"></param>
		public void MssQueueNativeBuild(string ssOperationId, long ssAppMobileConfigId, int ssMobilePlatformId, int ssRequesterUserId, string ssNativeHash, int ssSolutionPublishPlanId, bool ssNativeBuildsEnabled, RLIntegerRecordList ssUnavailableMobilePlatformsIds, out RLHEMessageRecordList ssMessages, out RCQueuedNativeBuildResultRecord ssResult) {
			ssMessages = new RLHEMessageRecordList();
			ssResult = new RCQueuedNativeBuildResultRecord(null);
			// TODO: Write implementation for action
		} // MssQueueNativeBuild

		/// <summary>
		/// Create a new audit message.
		/// This method does nothing if the Auditing feature is not available or configured.
		/// </summary>
		/// <param name="ssOperation"></param>
		/// <param name="ssMessage"></param>
		/// <param name="ssExtra"></param>
		public void MssAudit(string ssOperation, string ssMessage, string ssExtra) {
			// TODO: Write implementation for action
		} // MssAudit

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssAuthenticationProviderId"></param>
		/// <param name="ssUserPoolGuid"></param>
		public void MssAuthentication_GetUserAuthenticationDetails(int ssUserId, out int ssAuthenticationProviderId, out string ssUserPoolGuid) {
			ssAuthenticationProviderId = 0;
			ssUserPoolGuid = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GetUserAuthenticationDetails

		/// <summary>
		/// Change the audit configuration of a module. It will override any configuration made at the Environment level for this module.
		/// The configuration will be applied to the correspondent User Provider of that module instead of the module itself.
		/// </summary>
		/// <param name="ssModuleKey">Key of the module to configure. If empty the current caller will be used.</param>
		/// <param name="ssDispatcherURL">Url that will handle the audits.</param>
		/// <param name="ssDispatcherSecret">Optional secret configuration.</param>
		/// <param name="ssDispatcherTimeoutInMs">Optional timeout configuration.</param>
		public void MssAudit_SetConfiguration(string ssModuleKey, string ssDispatcherURL, string ssDispatcherSecret, int ssDispatcherTimeoutInMs) {
			// TODO: Write implementation for action
		} // MssAudit_SetConfiguration

		/// <summary>
		/// Change the audit configuration at the environment level.
		/// </summary>
		/// <param name="ssDispatcherURL">Url that will handle the audits.</param>
		/// <param name="ssDispatcherSecret">Optional secret configuration.</param>
		/// <param name="ssDispatcherTimeoutInMs">Optional timeout configuration.</param>
		public void MssAudit_SetEnvironmentConfiguration(string ssDispatcherURL, string ssDispatcherSecret, int ssDispatcherTimeoutInMs) {
			// TODO: Write implementation for action
		} // MssAudit_SetEnvironmentConfiguration

		/// <summary>
		/// Get the audit configuration at the environment level.
		/// </summary>
		/// <param name="ssDispatcherURL"></param>
		/// <param name="ssDispatcherSecret"></param>
		/// <param name="ssDispatcherTimeoutInMs"></param>
		public void MssAudit_GetEnvironmentConfiguration(out string ssDispatcherURL, out string ssDispatcherSecret, out int ssDispatcherTimeoutInMs) {
			ssDispatcherURL = "";
			ssDispatcherSecret = "";
			ssDispatcherTimeoutInMs = 0;
			// TODO: Write implementation for action
		} // MssAudit_GetEnvironmentConfiguration

		/// <summary>
		/// Get the audit configuration of a module.
		/// </summary>
		/// <param name="ssModuleKey">Key of the module to get the configuration. If empty the current caller will be used.</param>
		/// <param name="ssDispatcherURL"></param>
		/// <param name="ssDispatcherSecret"></param>
		/// <param name="ssDispatcherTimeoutInMs"></param>
		public void MssAudit_GetConfiguration(string ssModuleKey, out string ssDispatcherURL, out string ssDispatcherSecret, out int ssDispatcherTimeoutInMs) {
			ssDispatcherURL = "";
			ssDispatcherSecret = "";
			ssDispatcherTimeoutInMs = 0;
			// TODO: Write implementation for action
		} // MssAudit_GetConfiguration

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSystemPoolGuid"></param>
		public void MssAuthentication_GetSystemPoolGuid(out string ssSystemPoolGuid) {
			ssSystemPoolGuid = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GetSystemPoolGuid

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDefaultPoolGuid"></param>
		public void MssAuthentication_GetDefaultPoolGuid(out string ssDefaultPoolGuid) {
			ssDefaultPoolGuid = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GetDefaultPoolGuid

		/// <summary>
		/// Creates or updates a user pool with a specific GUID and Name. Returns true if the creation succeeds.
		/// </summary>
		/// <param name="ssUserPoolGuid"></param>
		/// <param name="ssName"></param>
		/// <param name="ssSuccess"></param>
		public void MssAuthentication_CreateOrUpdateUserPool(string ssUserPoolGuid, string ssName, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssAuthentication_CreateOrUpdateUserPool

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssUserPoolGuid"></param>
		public void MssUser_ChangeUserPool(int ssUserId, string ssUserPoolGuid) {
			// TODO: Write implementation for action
		} // MssUser_ChangeUserPool

		/// <summary>
		/// Returns the GUID of the user pool used to hold users that belong to the vendor
		/// </summary>
		/// <param name="ssVendorPoolGuid">The GUID of the pool</param>
		public void MssAuthentication_GetVendorPoolGuid(out string ssVendorPoolGuid) {
			ssVendorPoolGuid = "";
			// TODO: Write implementation for action
		} // MssAuthentication_GetVendorPoolGuid

		/// <summary>
		/// Returns a list of userids with the respective user pool filtered by the given user pool guid list. If the input list is empty then no filter is done and all users are returned, regardless of user pool.
		/// </summary>
		/// <param name="ssUserList">List of record UserWithUserPools</param>
		/// <param name="ssUserPoolList">List of user pool guids.</param>
		public void MssAuthentication_GetUsersWithPools(out RLUserWithUserPoolRecordList ssUserList, RLTextRecordList ssUserPoolList) {
			ssUserList = new RLUserWithUserPoolRecordList();
			// TODO: Write implementation for action
		} // MssAuthentication_GetUsersWithPools

		/// <summary>
		/// Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssConfiguration"></param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		public void MssExternalAuthentication_SetConfigurations(string ssWsURL, RLKeyValuePairRecordList ssConfiguration, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus) {
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			// TODO: Write implementation for action
		} // MssExternalAuthentication_SetConfigurations

		/// <summary>
		/// Acts like a proxy to the corresponding web service operation provided by an external authentication plugin.
		/// </summary>
		/// <param name="ssWsURL">The url of the plug-in&apos;s web service.</param>
		/// <param name="ssStatus">Info about the operation&apos;s execution.</param>
		/// <param name="ssConfiguration"></param>
		public void MssExternalAuthentication_GetAllConfigurations(string ssWsURL, out RCExternalAuthentication_PluginAPIStatusRecord ssStatus, out RLKeyValuePairRecordList ssConfiguration) {
			ssStatus = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			ssConfiguration = new RLKeyValuePairRecordList();
			// TODO: Write implementation for action
		} // MssExternalAuthentication_GetAllConfigurations

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssApplicationsDetails"></param>
		/// <param name="ssDeploymentId"></param>
		public void MssDeployPrepareDeployEspace(string ssOperationId, int ssEspaceVersionId, string ssEspaceName, string ssEspaceKey, string ssUsername, string ssUniqueId, RLApplicationModuleDetailsRecordList ssApplicationsDetails, out string ssDeploymentId) {
			ssDeploymentId = "";
			// TODO: Write implementation for action
		} // MssDeployPrepareDeployEspace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssAuthenticationProviderId"></param>
		/// <param name="ssPropertyName"></param>
		/// <param name="ssValue"></param>
		public void MssExternalAuthentication_ActiveProviderGetProperty(int ssAuthenticationProviderId, string ssPropertyName, out string ssValue) {
			ssValue = "";
			// TODO: Write implementation for action
		} // MssExternalAuthentication_ActiveProviderGetProperty

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserPoolGuid"></param>
		/// <param name="ssAuthenticationProviderId"></param>
		public void MssAuthentication_GetUserPoolAuthenticationProvider(string ssUserPoolGuid, out int ssAuthenticationProviderId) {
			ssAuthenticationProviderId = 0;
			// TODO: Write implementation for action
		} // MssAuthentication_GetUserPoolAuthenticationProvider

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssPreviousEspaceName"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssUsername"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssDeploymentId"></param>
		/// <param name="ssApplicationsDetails"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssUserId"></param>
		/// <param name="ssUserProviderKey"></param>
		/// <param name="ssInDebugMode"></param>
		/// <param name="ssCatalogId"></param>
		/// <param name="ssSuccess"></param>
		public void MssDeployFinalizeDeployEspaceSolution(string ssOperationId, string ssEspaceName, string ssPreviousEspaceName, string ssEspaceKey, string ssUsername, string ssUniqueId, string ssDeploymentId, RLApplicationModuleDetailsRecordList ssApplicationsDetails, int ssEspaceVersionId, int ssUserId, string ssUserProviderKey, bool ssInDebugMode, int ssCatalogId, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssDeployFinalizeDeployEspaceSolution

		/// <summary>
		/// Receives a feature name as input and returns if that feature is active for the current environment.
		/// </summary>
		/// <param name="ssFeatureName"></param>
		/// <param name="ssIsActive"></param>
		public void MssIsFeatureActive(string ssFeatureName, out string ssIsActive) {
			ssIsActive = "";
			// TODO: Write implementation for action
		} // MssIsFeatureActive

		/// <summary>
		/// Throw exception that was last thrown
		/// </summary>
		public void MssThrowLastException() {
			// TODO: Write implementation for action
		} // MssThrowLastException

		/// <summary>
		/// Returns the Application Identifier for a given application key and native platform.
		/// </summary>
		/// <param name="ssApplicationKey">Key of mobile application</param>
		/// <param name="ssNativePlatform">Type of native platform for the given application key (Android or iOS)</param>
		/// <param name="ssApplicationIdentifier">Unique ID used to identify the App on store and devices.</param>
		public void MssNativePlatforms_GetApplicationIdentifier(string ssApplicationKey, string ssNativePlatform, out string ssApplicationIdentifier) {
			ssApplicationIdentifier = "";
			// TODO: Write implementation for action
		} // MssNativePlatforms_GetApplicationIdentifier

		/// <summary>
		/// Redeploys an eSpace
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssEspaceVersionNumber"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssApplicationName"></param>
		/// <param name="ssFromUsername"></param>
		/// <param name="ssMessages"></param>
		public void MssRedeployEspace(string ssOperationId, int ssEspaceId, int ssEspaceVersionId, int ssEspaceVersionNumber, string ssEspaceKey, string ssEspaceName, string ssApplicationKey, string ssApplicationName, string ssFromUsername, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssRedeployEspace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssentityGUID"></param>
		/// <param name="ssespaceGUID"></param>
		/// <param name="ssexistingRecords"></param>
		public void MssGetRecordsMetadata(string ssentityGUID, string ssespaceGUID, out RLEntityRecordRecordList ssexistingRecords) {
			ssexistingRecords = new RLEntityRecordRecordList();
			// TODO: Write implementation for action
		} // MssGetRecordsMetadata

		/// <summary>
		/// Returns a list of all available deployment zones.
		/// Even though the output strucuture has a list of application and espace keys, those are not being returned in this method.
		/// </summary>
		/// <param name="ssSearchKeyWord">A string to search deployment zones</param>
		/// <param name="ssDeploymentZones"> A list of deployment zones which name or description match the search keyword. If the searchkeyword is empty, all deployment zones must be returned</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZones_List(string ssSearchKeyWord, out RLDeploymentZoneRecordList ssDeploymentZones, out bool ssSuccess, out string ssMessage) {
			ssDeploymentZones = new RLDeploymentZoneRecordList();
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZones_List

		/// <summary>
		/// This action will return the deployment zones with all its details, including application and espace keys.
		/// </summary>
		/// <param name="ssDeploymentZoneKey">The identifier of the deployment zone to get</param>
		/// <param name="ssDeploymentZone">The matching deployment zone, if any</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise</param>
		public void MssDeploymentZone_Get(string ssDeploymentZoneKey, out RCDeploymentZoneRecord ssDeploymentZone, out bool ssSuccess, out string ssMessage) {
			ssDeploymentZone = new RCDeploymentZoneRecord(null);
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_Get

		/// <summary>
		/// Create or update a Deployment Zone
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssDeploymentZone">The deployment zone to create, if the key is null, or to update, if there�s a matching zone.</param>
		/// <param name="ssDeploymentZoneKey">The key of the deployment zone that was created or updated, or null if a key was supplied and there�s no matching deployment zone</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds</param>
		/// <param name="ssNeedsModulesRepublish">A boolean set to true when we need to mark all modules as needing republish</param>
		/// <param name="ssMessages">Operation messages</param>
		public void MssDeploymentZone_CreateOrUpdate(string ssOperationId, RCDeploymentZoneRecord ssDeploymentZone, out string ssDeploymentZoneKey, out bool ssSuccess, out bool ssNeedsModulesRepublish, out RLHEMessageRecordList ssMessages) {
			ssDeploymentZoneKey = "";
			ssSuccess = false;
			ssNeedsModulesRepublish = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDeploymentZone_CreateOrUpdate

		/// <summary>
		/// Returns a list of all deployment technologies installed on the environment.
		/// </summary>
		/// <param name="ssDeploymentTechnologies">List of all deployment technologies installed on the environment</param>
		public void MssDeploymentTechnology_List(out RLDeploymentTechnologyRecordList ssDeploymentTechnologies) {
			ssDeploymentTechnologies = new RLDeploymentTechnologyRecordList();
			// TODO: Write implementation for action
		} // MssDeploymentTechnology_List

		/// <summary>
		/// Delete a Deployment Zone
		/// </summary>
		/// <param name="ssDeploymentZoneKey">The deployment zone to delete</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise</param>
		public void MssDeploymentZone_Delete(string ssDeploymentZoneKey, out bool ssSuccess, out string ssMessage) {
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_Delete

		/// <summary>
		/// Sets that the given Deployment Zone should be used to deploy modules that aren’t explicitly associated with any Deployment Zone.
		/// </summary>
		/// <param name="ssDeploymentZoneKey">The identifier of the deployment zone to set as default</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZone_SetDefault(string ssDeploymentZoneKey, out bool ssSuccess, out string ssMessage) {
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_SetDefault

		/// <summary>
		/// Associate a given Module with a given Deployment Zone.
		/// </summary>
		/// <param name="ssKey">Key of the Module to associate.</param>
		/// <param name="ssDeploymentZoneKey">Key of the Deployment Zone to associate.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZone_ModuleSet(string ssKey, string ssDeploymentZoneKey, out bool ssSuccess, out string ssMessage) {
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_ModuleSet

		/// <summary>
		/// Get Deployment Zone associated to a given Module.
		/// </summary>
		/// <param name="ssKey">Key of the Module to get configuration.</param>
		/// <param name="ssDeploymentZone">Deployment Zone to which the Application is assoicated.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZone_ModuleGet(string ssKey, out RCDeploymentZoneRecord ssDeploymentZone, out bool ssSuccess, out string ssMessage) {
			ssDeploymentZone = new RCDeploymentZoneRecord(null);
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_ModuleGet

		/// <summary>
		/// Validates if solution includes applications that are not complete, those are not valid in docker
		/// </summary>
		/// <param name="ssSolutionRecord"></param>
		/// <param name="ssSolutionId"></param>
		/// <param name="ssSolutionVersionId"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssIsDownload"></param>
		public void MssCheckPartialApplicationSolutionPublish(RCSolutionPack_SolutionRecord ssSolutionRecord, int ssSolutionId, int ssSolutionVersionId, out RLHEMessageRecordList ssMessages, bool ssIsDownload) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssCheckPartialApplicationSolutionPublish

		/// <summary>
		/// Get Deployment Zones associated to a given Application.
		/// </summary>
		/// <param name="ssKey">Key of the Application to get configuration.</param>
		/// <param name="ssDeploymentZones">Deployment Zones to which the Application is assoicated.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZone_ApplicationGet(string ssKey, out RLDeploymentZoneRecordList ssDeploymentZones, out bool ssSuccess, out string ssMessage) {
			ssDeploymentZones = new RLDeploymentZoneRecordList();
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_ApplicationGet

		/// <summary>
		/// Associate a given Application with a given Deployment Zone.
		/// </summary>
		/// <param name="ssKey">Key of the Application to associate.</param>
		/// <param name="ssDeploymentZoneKey">Key of the Deployment Zone to associate.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZone_ApplicationSet(string ssKey, string ssDeploymentZoneKey, out bool ssSuccess, out string ssMessage) {
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_ApplicationSet

		/// <summary>
		/// Check if a given Deployment Technology has a given capability
		/// </summary>
		/// <param name="ssDeploymentTechnologyKey">Key of the Deployment Technology to check.</param>
		/// <param name="ssCapability">Name of the Capability to check.</param>
		/// <param name="ssHasCapability">Result of the operation.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentTechnology_HasCapability(string ssDeploymentTechnologyKey, string ssCapability, out bool ssHasCapability, out bool ssSuccess, out string ssMessage) {
			ssHasCapability = false;
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentTechnology_HasCapability

		/// <summary>
		/// Get Deployment Zones associated to a given Server
		/// </summary>
		/// <param name="ssServerId">Id of the Server to get associated Deployment Zones.</param>
		/// <param name="ssDeploymentZones">Deployment Zones to which the Server is assoicated.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentZone_ServerGet(int ssServerId, out RLDeploymentZoneRecordList ssDeploymentZones, out bool ssSuccess, out string ssMessage) {
			ssDeploymentZones = new RLDeploymentZoneRecordList();
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_ServerGet

		/// <summary>
		/// Returns deployment technology details
		/// </summary>
		/// <param name="ssDeploymentTechnologyKey">The identifier of the deployment technology to get.</param>
		/// <param name="ssDeploymentTechnology">The matching deployment technology, if any.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessage">Empty if success is true, an error message otherwise.</param>
		public void MssDeploymentTechnology_Get(string ssDeploymentTechnologyKey, out RCDeploymentTechnologyRecord ssDeploymentTechnology, out bool ssSuccess, out string ssMessage) {
			ssDeploymentTechnology = new RCDeploymentTechnologyRecord(null);
			ssSuccess = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssDeploymentTechnology_Get

		/// <summary>
		/// Checks if the Deployment Technology associated with the given Deployment Zone is properly configured, by running validations specific to that Deployment Technology.
		/// </summary>
		/// <param name="ssDeploymentZone">Deployment Zone to be validated.</param>
		/// <param name="ssSuccess">A boolean set to true when the action succeeds.</param>
		/// <param name="ssMessages">Includes success messages if success is true; otherwise, a list of reasons of why the configuration was deemed invalid.</param>
		public void MssDeploymentZone_TestConfiguration(RCDeploymentZoneRecord ssDeploymentZone, out bool ssSuccess, out RLHEMessageRecordList ssMessages) {
			ssSuccess = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDeploymentZone_TestConfiguration

		/// <summary>
		/// Generates a zip file containing all the source code for the extension definitions (e.g. actions, structures, entities)
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssXIF"></param>
		/// <param name="ssSourceCodeZip"></param>
		/// <param name="ssMessages"></param>
		public void MssGenerateExtensionStubs(string ssOperationId, byte[] ssXIF, out byte[] ssSourceCodeZip, out RLHEMessageRecordList ssMessages) {
			ssSourceCodeZip = new byte[] {};
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssGenerateExtensionStubs

		/// <summary>
		/// Generates a zip file containing all the dependencies needed to compile an extension
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssDependenciesZip"></param>
		/// <param name="ssMessages"></param>
		public void MssGetExtensionDependencies(string ssOperationId, out byte[] ssDependenciesZip, out RLHEMessageRecordList ssMessages) {
			ssDependenciesZip = new byte[] {};
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssGetExtensionDependencies

		/// <summary>
		/// Sends a telemetry event to our data lake
		/// </summary>
		/// <param name="ssConsole">Console where the event is being generated. E.g.: LifeTime, ServiceCenter</param>
		/// <param name="ssType">Type of the event, console specific. E.g: Deployment Started, etc...</param>
		/// <param name="ssDomain">Domain sent in JSON</param>
		/// <param name="ssVersion">Version of the component to be logged. Empty string if same as platform server</param>
		public void MssSendConsoleEvent(string ssConsole, string ssType, string ssDomain, string ssVersion) {
			// TODO: Write implementation for action
		} // MssSendConsoleEvent

		/// <summary>
		/// Sends the last thrown exception to our data lake
		/// </summary>
		/// <param name="ssVersion">Component Version to override platform&apos;s version if necessary</param>
		/// <param name="ssComponent">Component where the event is being generated. E.g.: LifeTime, ServiceCenter</param>
		/// <param name="ssEventId"></param>
		public void MssSendLastThrownException(string ssVersion, string ssComponent, out string ssEventId) {
			ssEventId = "";
			// TODO: Write implementation for action
		} // MssSendLastThrownException

		/// <summary>
		/// Attach a file to a telemetry event
		/// </summary>
		/// <param name="ssComponent"></param>
		/// <param name="ssVersion"></param>
		/// <param name="ssRelatedEventId"></param>
		/// <param name="ssData"></param>
		/// <param name="ssName"></param>
		/// <param name="ssDescription"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssEventId"></param>
		public void MssSendAttachment(string ssComponent, string ssVersion, string ssRelatedEventId, byte[] ssData, string ssName, string ssDescription, out bool ssSuccess, out string ssEventId) {
			ssSuccess = false;
			ssEventId = "";
			// TODO: Write implementation for action
		} // MssSendAttachment

		/// <summary>
		/// Sends user feedback, to relate a feedback with an error please use the RelatedEventId input.
		/// </summary>
		/// <param name="ssComponent"></param>
		/// <param name="ssVersion"></param>
		/// <param name="ssMessage"></param>
		/// <param name="ssName"></param>
		/// <param name="ssEmail"></param>
		/// <param name="ssRelatedEventId"></param>
		/// <param name="ssLocation"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssEventId"></param>
		public void MssSendUserFeedback(string ssComponent, string ssVersion, string ssMessage, string ssName, string ssEmail, string ssRelatedEventId, string ssLocation, out bool ssSuccess, out string ssEventId) {
			ssSuccess = false;
			ssEventId = "";
			// TODO: Write implementation for action
		} // MssSendUserFeedback

		/// <summary>
		/// Start an operation that will bring into effect, at runtime, the configurations currently set for given modules.
		/// </summary>
		/// <param name="ssModuleKeys"> Keys of the modules whose configurations should be made effective.</param>
		/// <param name="ssForbidConsumersPropagation">If true, the algorithm will update just the configurations of the modules taken as input, ignoring their consumers.</param>
		/// <param name="ssAsyncOperationID">ID of the operation that was initiated.</param>
		public void MssConfigurations_StartApplyModules(RLTextRecordList ssModuleKeys, bool ssForbidConsumersPropagation, out int ssAsyncOperationID) {
			ssAsyncOperationID = 0;
			// TODO: Write implementation for action
		} // MssConfigurations_StartApplyModules

		/// <summary>
		/// Start an operation that will bring into effect, at runtime, configurations for all modules contained in the given application.
		/// </summary>
		/// <param name="ssApplicationKey">Key of the application whose configurations should be made effective.</param>
		/// <param name="ssForbidConsumersPropagation">If true, the algorithm will update just the configurations of the modules taken as input, ignoring their consumers.</param>
		/// <param name="ssAsyncOperationID">ID of the operation that was initiated.</param>
		public void MssConfigurations_StartApplyApplication(string ssApplicationKey, bool ssForbidConsumersPropagation, out int ssAsyncOperationID) {
			ssAsyncOperationID = 0;
			// TODO: Write implementation for action
		} // MssConfigurations_StartApplyApplication

		/// <summary>
		/// Start an operation that will bring into effect, at runtime, configurations currently set for all modules in the environment.
		/// </summary>
		/// <param name="ssAsyncOperationID">ID of the operation that was initiated.</param>
		public void MssConfigurations_StartApplyEnvironment(out int ssAsyncOperationID) {
			ssAsyncOperationID = 0;
			// TODO: Write implementation for action
		} // MssConfigurations_StartApplyEnvironment

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssServiceStatus"></param>
		public void MssGetCacheInvalidationServiceStatus(out RCCacheInvalidationServiceStatusRecord ssServiceStatus) {
			ssServiceStatus = new RCCacheInvalidationServiceStatusRecord(null);
			// TODO: Write implementation for action
		} // MssGetCacheInvalidationServiceStatus

		/// <summary>
		/// Gets the debug mode value.
		/// </summary>
		/// <param name="ssIsDebugModeActive">The debug mode value.</param>
		public void MssConfigurations_GetDebugMode(out bool ssIsDebugModeActive) {
			ssIsDebugModeActive = false;
			// TODO: Write implementation for action
		} // MssConfigurations_GetDebugMode

		/// <summary>
		/// Sets the debug mode value.
		/// </summary>
		/// <param name="ssIsDebugModeActive">The debug mode value.</param>
		public void MssConfigurations_SetDebugMode(bool ssIsDebugModeActive) {
			// TODO: Write implementation for action
		} // MssConfigurations_SetDebugMode

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssProducerVersionId"></param>
		/// <param name="ssProducerKey"></param>
		/// <param name="ssProducerKind"></param>
		/// <param name="ssProducerEspaceType"></param>
		/// <param name="ssMessages"></param>
		public void MssCheckConsumerReferencesAndUpdateRuntime(string ssOperationId, int ssProducerVersionId, string ssProducerKey, string ssProducerKind, string ssProducerEspaceType, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssCheckConsumerReferencesAndUpdateRuntime

		/// <summary>
		/// Checks if a given capability is available.
		/// </summary>
		/// <param name="ssCapability">The name of the capability.
		///  </param>
		/// <param name="ssIsAvailable">True if the capability is available; false, otherwise.</param>
		/// <param name="ssReason">If the given capability is not available, this parameter holds a message explaining why that is so. Otherwise, it holds a blank string.</param>
		public void MssServerCapabilities_IsCapabilityAvailable(string ssCapability, out bool ssIsAvailable, out string ssReason) {
			ssIsAvailable = false;
			ssReason = "";
			// TODO: Write implementation for action
		} // MssServerCapabilities_IsCapabilityAvailable

		/// <summary>
		/// Updates references information for an eSpace. Updated information: broken references, missing or inconsistent references, old producers references.
		/// </summary>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssUserProviderKey"></param>
		public void MssUpdateReferencesMetaModel(int ssEspaceId, string ssEspaceKey, string ssUserProviderKey) {
			// TODO: Write implementation for action
		} // MssUpdateReferencesMetaModel

		/// <summary>
		/// Refresh licensed features state
		/// </summary>
		/// <param name="ssSkipComplexityCheck"></param>
		/// <param name="ssOk"></param>
		/// <param name="ssMessages"></param>
		public void MssActivationRefreshLicensedFeatures(bool ssSkipComplexityCheck, out bool ssOk, out RLHEMessageRecordList ssMessages) {
			ssOk = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssActivationRefreshLicensedFeatures

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOk"></param>
		public void MssRefreshISAPIFilters(out bool ssOk) {
			ssOk = false;
			// TODO: Write implementation for action
		} // MssRefreshISAPIFilters

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFrontendName"></param>
		public void MssDeleteModuleLinksToFrontend(string ssFrontendName) {
			// TODO: Write implementation for action
		} // MssDeleteModuleLinksToFrontend

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssOnlyRefreshIfBrokenReferences"></param>
		/// <param name="ssNeedsRefreshReferences"></param>
		public void MssEspace_NeedsRefreshReferences(int ssEspaceId, bool ssOnlyRefreshIfBrokenReferences, out bool ssNeedsRefreshReferences) {
			ssNeedsRefreshReferences = false;
			// TODO: Write implementation for action
		} // MssEspace_NeedsRefreshReferences

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssESpaceKey"></param>
		/// <param name="ssESpaceName"></param>
		public void MssReloadESpace(string ssESpaceKey, string ssESpaceName) {
			// TODO: Write implementation for action
		} // MssReloadESpace

		/// <summary>
		/// Check if a given deployment technology capability is available for on a given module
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssOperation">Text description of operation to be performed on the module.
		/// Acceptable inputs: Records from Static entity DepTechCapability</param>
		/// <param name="ssHasCapability"></param>
		/// <param name="ssCurrentZoneSupportsCapability">True if the current deployment zone supports this capability</param>
		/// <param name="ssDeploymentZoneName">Name of the deployment zone currently set</param>
		public void MssDeploymentZone_IsCapabilityAvailableForModule(string ssModuleKey, string ssOperation, out bool ssHasCapability, out bool ssCurrentZoneSupportsCapability, out string ssDeploymentZoneName) {
			ssHasCapability = false;
			ssCurrentZoneSupportsCapability = false;
			ssDeploymentZoneName = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_IsCapabilityAvailableForModule

		/// <summary>
		/// Check if a given deployment technology capability is available for on a given application
		/// </summary>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssCapability">Text description of operation to be performed on the application.
		/// Acceptable inputs: Records from Static entity DepTechCapability</param>
		/// <param name="ssHasCapability"></param>
		/// <param name="ssCurrentZoneSupportsCapability">True if the current deployment zone supports this capability</param>
		/// <param name="ssDeploymentZoneName">Name of the deployment zone currently set</param>
		public void MssDeploymentZone_IsCapabilityAvailableForApplication(string ssApplicationKey, string ssCapability, out bool ssHasCapability, out bool ssCurrentZoneSupportsCapability, out string ssDeploymentZoneName) {
			ssHasCapability = false;
			ssCurrentZoneSupportsCapability = false;
			ssDeploymentZoneName = "";
			// TODO: Write implementation for action
		} // MssDeploymentZone_IsCapabilityAvailableForApplication

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssSecurityLevel"></param>
		public void MssSecurity_CheckUserPermissionsForEspace(int ssUserId, int ssEspaceId, out int ssSecurityLevel) {
			ssSecurityLevel = 0;
			// TODO: Write implementation for action
		} // MssSecurity_CheckUserPermissionsForEspace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssIncludeInactive"></param>
		/// <param name="ssSecurityGrants"></param>
		public void MssSecurityGetUserSecurityGrants(int ssUserId, bool ssIncludeInactive, out RCUserSecurityGrantsRecord ssSecurityGrants) {
			ssSecurityGrants = new RCUserSecurityGrantsRecord(null);
			// TODO: Write implementation for action
		} // MssSecurityGetUserSecurityGrants

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceKey">espace key of the event watcher</param>
		/// <param name="ssEventType">e.g. EspacePublish</param>
		/// <param name="ssRelativeUrl">relative url where the notifications will be sent</param>
		/// <param name="ssListenerUniqueId">Unique id used during the registration</param>
		public void MssEventNotification_Register(string ssEspaceKey, string ssEventType, string ssRelativeUrl, string ssListenerUniqueId) {
			// TODO: Write implementation for action
		} // MssEventNotification_Register

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceKey">espace key of the event watcher</param>
		/// <param name="ssEventType">e.g. EspacePublish</param>
		public void MssEventNotification_Unregister(string ssEspaceKey, string ssEventType) {
			// TODO: Write implementation for action
		} // MssEventNotification_Unregister

		/// <summary>
		/// Get information from espace version in server:
		/// - CatalogId
		/// - Conflict information
		/// - Fragments
		/// </summary>
		/// <param name="ssIsCatalogIdNeeded"></param>
		/// <param name="ssIsConflictCheckNeeded"></param>
		/// <param name="ssAreFragmentsNeeded"></param>
		/// <param name="ssUserId"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssLastSolvedConflictVersion">Last version where a conflict was solved.</param>
		/// <param name="ssVersionGeneralHash">eSpace&apos;s version general hash</param>
		/// <param name="ssEspaceVersionHistory"></param>
		/// <param name="ssDBCatalogId">DBCatalogId which should be used for the next publish</param>
		/// <param name="ssVersionComparison"></param>
		/// <param name="ssFragments">Fragments used for partial upload</param>
		public void MssCompareEspaceToServerVersion(bool ssIsCatalogIdNeeded, bool ssIsConflictCheckNeeded, bool ssAreFragmentsNeeded, int ssUserId, string ssEspaceKey, int ssLastSolvedConflictVersion, string ssVersionGeneralHash, byte[] ssEspaceVersionHistory, out int ssDBCatalogId, out RCVersionComparisonRecord ssVersionComparison, out string ssFragments) {
			ssDBCatalogId = 0;
			ssVersionComparison = new RCVersionComparisonRecord(null);
			ssFragments = "";
			// TODO: Write implementation for action
		} // MssCompareEspaceToServerVersion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssEspaceVersionId"></param>
		/// <param name="ssPreviousEspaceVersionId"></param>
		public void MssEventNotification_RaiseEventEspacePublish(string ssOperationId, string ssEspaceKey, string ssEspaceName, int ssEspaceVersionId, int ssPreviousEspaceVersionId) {
			// TODO: Write implementation for action
		} // MssEventNotification_RaiseEventEspacePublish

		/// <summary>
		/// Returns a list of catalogs available to this user and that match the filters
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssNameFilter"></param>
		/// <param name="ssDBCatalogs"></param>
		public void MssGetDBCatalogsForDeveloper(int ssUserId, string ssNameFilter, out RLDBCatalogRecordList ssDBCatalogs) {
			ssDBCatalogs = new RLDBCatalogRecordList();
			// TODO: Write implementation for action
		} // MssGetDBCatalogsForDeveloper

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssUserId"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssSolutionPublishPlanId"></param>
		/// <param name="ssUnavailableMobilePlatforms"></param>
		/// <param name="ssLaunchNativeBuildsIfNecessary"></param>
		/// <param name="ssQueuedNativeBuilds"></param>
		/// <param name="ssAppsToGenerateButServiceDown"></param>
		/// <param name="ssAppsToGenerateButServiceOff"></param>
		/// <param name="ssNativeHash"></param>
		public void MssNativeBuilds_GetNeeded(string ssOperationId, int ssUserId, string ssApplicationKey, int ssSolutionPublishPlanId, RLKeyValuePairRecordList ssUnavailableMobilePlatforms, bool ssLaunchNativeBuildsIfNecessary, out RLIntegerRecordList ssQueuedNativeBuilds, out RLTextRecordList ssAppsToGenerateButServiceDown, out RLTextRecordList ssAppsToGenerateButServiceOff, out string ssNativeHash) {
			ssQueuedNativeBuilds = new RLIntegerRecordList();
			ssAppsToGenerateButServiceDown = new RLTextRecordList();
			ssAppsToGenerateButServiceOff = new RLTextRecordList();
			ssNativeHash = "";
			// TODO: Write implementation for action
		} // MssNativeBuilds_GetNeeded

		/// <summary>
		/// Gets the address associated with zone where the Module is deployed, including Scheme (http or https)
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssAddress"></param>
		public void MssDeploymentZoneResolution_ByModuleKeyWithScheme(string ssModuleKey, out string ssAddress) {
			ssAddress = "";
			// TODO: Write implementation for action
		} // MssDeploymentZoneResolution_ByModuleKeyWithScheme

		/// <summary>
		/// Validates messages received by the event notification system.
		/// It ensures they were sent from an authenticated component.
		/// </summary>
		/// <param name="ssUrl">Url called (query parameters included)</param>
		/// <param name="ssAuthorizationHeader">Full content of the message&apos;s authorization header</param>
		/// <param name="ssDateHeader">Full content of the message&apos;s date header</param>
		/// <param name="ssListenerUniqueId">Unique id used during the registration</param>
		/// <param name="ssValid">True if message is valid and the sender authenticated</param>
		/// <param name="ssMessage">Error message</param>
		public void MssEventNotification_ValidateMessage(string ssUrl, string ssAuthorizationHeader, string ssDateHeader, string ssListenerUniqueId, out bool ssValid, out RCHEMessageRecord ssMessage) {
			ssValid = false;
			ssMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssEventNotification_ValidateMessage

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssHeaderName"></param>
		/// <param name="ssValue"></param>
		public void MssGetRequestHeader(string ssHeaderName, out string ssValue) {
			ssValue = "";
			// TODO: Write implementation for action
		} // MssGetRequestHeader

		/// <summary>
		/// 1CP delete refactoring
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssUserID"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssMessages"></param>
		public void MssRemoveEspace(string ssOperationId, string ssEspaceKey, int ssUserID, out bool ssSuccess, out RLHEMessageRecordList ssMessages) {
			ssSuccess = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssRemoveEspace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssExtensionId"></param>
		/// <param name="ssSecurityLevel"></param>
		public void MssSecurity_CheckUserPermissionsForExtension(int ssUserId, int ssExtensionId, out int ssSecurityLevel) {
			ssSecurityLevel = 0;
			// TODO: Write implementation for action
		} // MssSecurity_CheckUserPermissionsForExtension

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssSecurityLevel"></param>
		public void MssSecurity_CheckUserPermissionsForApplication(int ssUserId, string ssApplicationKey, out int ssSecurityLevel) {
			ssSecurityLevel = 0;
			// TODO: Write implementation for action
		} // MssSecurity_CheckUserPermissionsForApplication

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssOML"></param>
		/// <param name="ssMessages"></param>
		public void MssEspace_AssociateDependencies(int ssUserId, int ssEspaceId, byte[] ssOML, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssEspace_AssociateDependencies

		/// <summary>
		/// Move module identified by ModuleKey to application identified by ToApplicationKey
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssModuleKey">Module to be moved</param>
		/// <param name="ssToApplicationKey">Target application</param>
		/// <param name="ssSuccess">Returns true if operation was a success</param>
		/// <param name="ssMessages">List of messages returned by operation</param>
		public void MssMoveModule(int ssUserId, string ssModuleKey, string ssToApplicationKey, out bool ssSuccess, out RLHEMessageRecordList ssMessages) {
			ssSuccess = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssMoveModule

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssOml"></param>
		/// <param name="ssCatalogId"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssReplaceEspaceWithSameName"></param>
		/// <param name="ssCommitMessage"></param>
		/// <param name="ssOk"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssVersionId"></param>
		/// <param name="ssVersionNumber"></param>
		/// <param name="ssBasedOnPreviousVersion"></param>
		/// <param name="ssExistsWithDifferentKey"></param>
		/// <param name="ssMessages"></param>
		public void MssUploadEspace(int ssUserId, byte[] ssOml, int ssCatalogId, string ssApplicationKey, bool ssReplaceEspaceWithSameName, string ssCommitMessage, out bool ssOk, out int ssEspaceId, out int ssVersionId, out int ssVersionNumber, out bool ssBasedOnPreviousVersion, out bool ssExistsWithDifferentKey, out RLHEMessageRecordList ssMessages) {
			ssOk = false;
			ssEspaceId = 0;
			ssVersionId = 0;
			ssVersionNumber = 0;
			ssBasedOnPreviousVersion = false;
			ssExistsWithDifferentKey = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssUploadEspace

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId">Identifier of user performing this operation</param>
		/// <param name="ssExtensionKey">Identifier of extension that should be deleted</param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssErrorMessages">List of error messages if there are any</param>
		public void MssDeleteExtension(int ssUserId, string ssExtensionKey, out bool ssSuccess, out RLHEMessageRecordList ssErrorMessages) {
			ssSuccess = false;
			ssErrorMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDeleteExtension

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssApplicationKey"></param>
		/// <param name="ssReferenceableModules"></param>
		public void MssModules_ListReferenceable(int ssUserId, string ssEspaceKey, string ssApplicationKey, out RLReferenceableModuleRecordList ssReferenceableModules) {
			ssReferenceableModules = new RLReferenceableModuleRecordList();
			// TODO: Write implementation for action
		} // MssModules_ListReferenceable

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssEspaceVersionHash"></param>
		/// <param name="ssIsNeeded"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssEqualEspaceVersionId"></param>
		/// <param name="ssRunningEspaceVersionId"></param>
		/// <param name="ssRunningEspaceVersionNumber"></param>
		/// <param name="ssMessage"></param>
		public void MssIsUploadEspaceNeeded(string ssEspaceKey, string ssEspaceVersionHash, out bool ssIsNeeded, out int ssEspaceId, out int ssEqualEspaceVersionId, out int ssRunningEspaceVersionId, out int ssRunningEspaceVersionNumber, out RCHEMessageRecord ssMessage) {
			ssIsNeeded = false;
			ssEspaceId = 0;
			ssEqualEspaceVersionId = 0;
			ssRunningEspaceVersionId = 0;
			ssRunningEspaceVersionNumber = 0;
			ssMessage = new RCHEMessageRecord(null);
			// TODO: Write implementation for action
		} // MssIsUploadEspaceNeeded

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssAppKey"></param>
		/// <param name="ssUserId"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssMessages"></param>
		public void MssDeleteApplication(string ssOperationId, string ssAppKey, int ssUserId, out bool ssSuccess, out RLHEMessageRecordList ssMessages) {
			ssSuccess = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssDeleteApplication

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEspaceToPublish"></param>
		/// <param name="ssEspacePublishOptions"></param>
		/// <param name="ssEspacePublishAsyncResult"></param>
		public void MssPublishEspaceAsync(RCEspaceToPublishRecord ssEspaceToPublish, RCEspacePublishOptionsRecord ssEspacePublishOptions, out RCEspacePublishAsyncResultRecord ssEspacePublishAsyncResult) {
			ssEspacePublishAsyncResult = new RCEspacePublishAsyncResultRecord(null);
			// TODO: Write implementation for action
		} // MssPublishEspaceAsync

		/// <summary>
		/// Move module identified by ModuleKey to application identified by ToApplicationKey
		/// Warning: This should only be used during the solution publish, given it&apos;s not validating deployment zones constraints
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssModuleKey">Module to be moved</param>
		/// <param name="ssToApplicationKey">Target application</param>
		/// <param name="ssSuccess">Returns true if operation was a success</param>
		/// <param name="ssMessages">List of messages returned by operation</param>
		public void MssSolution_MoveModule(int ssUserId, string ssModuleKey, string ssToApplicationKey, out bool ssSuccess, out RLHEMessageRecordList ssMessages) {
			ssSuccess = false;
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssSolution_MoveModule

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssEspaceName"></param>
		/// <param name="ssOML"></param>
		/// <param name="ssQueryCompoundKey"></param>
		/// <param name="ssResultCode"></param>
		/// <param name="ssErrorText"></param>
		/// <param name="ssGeneratedSQL"></param>
		/// <param name="ssParametersMapping"></param>
		public void MssConvertToAdvancedQuery(string ssOperationId, int ssEspaceId, string ssEspaceName, byte[] ssOML, string ssQueryCompoundKey, out string ssResultCode, out string ssErrorText, out string ssGeneratedSQL, out RLKeyValuePairRecordList ssParametersMapping) {
			ssResultCode = "";
			ssErrorText = "";
			ssGeneratedSQL = "";
			ssParametersMapping = new RLKeyValuePairRecordList();
			// TODO: Write implementation for action
		} // MssConvertToAdvancedQuery

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssCurrentEnvironmentFeatures"></param>
		/// <param name="ssOtherEnvironments"></param>
		public void MssEnvironmentFeature_List(out RLFeatureInfoRecordList ssCurrentEnvironmentFeatures, out RLEnvironmentInfoRecordList ssOtherEnvironments) {
			ssCurrentEnvironmentFeatures = new RLFeatureInfoRecordList();
			ssOtherEnvironments = new RLEnvironmentInfoRecordList();
			// TODO: Write implementation for action
		} // MssEnvironmentFeature_List

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFeatureId"></param>
		/// <param name="ssEnabled"></param>
		public void MssEnvironmentFeature_Toggle(string ssFeatureId, bool ssEnabled) {
			// TODO: Write implementation for action
		} // MssEnvironmentFeature_Toggle

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEnvironments"></param>
		public void MssEnvironmentFeature_SyncAll(RLEnvironmentInfoRecordList ssEnvironments) {
			// TODO: Write implementation for action
		} // MssEnvironmentFeature_SyncAll

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssPublicElements"></param>
		public void MssModules_GetPublicElements(int ssUserId, out RLPublicElementRecordList ssPublicElements) {
			ssPublicElements = new RLPublicElementRecordList();
			// TODO: Write implementation for action
		} // MssModules_GetPublicElements

		/// <summary>
		/// Get Server.API internal address for Service Center
		/// </summary>
		/// <param name="ssAddress">Address where Service Center can reach the Server.API</param>
		public void MssGetServerAPIAddress(out string ssAddress) {
			ssAddress = "";
			// TODO: Write implementation for action
		} // MssGetServerAPIAddress

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssoml"></param>
		/// <param name="ssmodelFeatures"></param>
		public void MssGetModelFeatures(byte[] ssoml, out RLModuleVersionFeatureRecordList ssmodelFeatures) {
			ssmodelFeatures = new RLModuleVersionFeatureRecordList();
			// TODO: Write implementation for action
		} // MssGetModelFeatures

		/// <summary>
		/// This method will generate a new user with username admin in the given tenant and eSpace.
		/// </summary>
		/// <param name="ssTenantId"></param>
		/// <param name="ssEspaceId"></param>
		/// <param name="ssPassword"></param>
		public void MssUserProvider_SetupAdminUser(int ssTenantId, int ssEspaceId, string ssPassword) {
			// TODO: Write implementation for action
		} // MssUserProvider_SetupAdminUser

		/// <summary>
		/// Decrypt information encrypted for WebService requests
		/// </summary>
		/// <param name="ssEncryptedValue"></param>
		/// <param name="ssDecryptedValue"></param>
		/// <param name="ssSuccess"></param>
		public void MssDecryptWebServiceInformation(string ssEncryptedValue, out string ssDecryptedValue, out bool ssSuccess) {
			ssDecryptedValue = "";
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssDecryptWebServiceInformation

		/// <summary>
		/// Get the sandbox key if it is in sanbox mode. Empty string otherwise.
		/// </summary>
		/// <param name="ssSandboxKey"></param>
		public void MssGetSandboxKey(out string ssSandboxKey) {
			ssSandboxKey = "";
			// TODO: Write implementation for action
		} // MssGetSandboxKey

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssExtensionKey"></param>
		/// <param name="ssEntitiesConfig"></param>
		public void MssModules_GetExtensionEntitiesConfigs(string ssExtensionKey, out RLExtensionEntityConfigRecordList ssEntitiesConfig) {
			ssEntitiesConfig = new RLExtensionEntityConfigRecordList();
			// TODO: Write implementation for action
		} // MssModules_GetExtensionEntitiesConfigs

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssEntityConfig"></param>
		public void MssModules_SetExtensionEntityConfig(RCExtensionEntityConfigRecord ssEntityConfig) {
			// TODO: Write implementation for action
		} // MssModules_SetExtensionEntityConfig

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPlaintext"></param>
		/// <param name="ssAssociatedData"></param>
		/// <param name="ssCipheredData"></param>
		public void MssCryptography_AuthEncryptTextWithAssociatedData(string ssPlaintext, string ssAssociatedData, out byte[] ssCipheredData) {
			ssCipheredData = new byte[] {};
			// TODO: Write implementation for action
		} // MssCryptography_AuthEncryptTextWithAssociatedData

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssCipheredText"></param>
		/// <param name="ssAssociatedData"></param>
		/// <param name="ssPlaintext"></param>
		public void MssCryptography_AuthDecryptTextWithAssociatedData(byte[] ssCipheredText, string ssAssociatedData, out string ssPlaintext) {
			ssPlaintext = "";
			// TODO: Write implementation for action
		} // MssCryptography_AuthDecryptTextWithAssociatedData

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssSolutionPublishId"></param>
		/// <param name="ssOperationId"></param>
		/// <param name="ssSuccess"></param>
		public void MssModule_UpgradeREM(string ssModuleKey, string ssSolutionPublishId, string ssOperationId, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssModule_UpgradeREM

		/// <summary>
		/// Get information from espace version in server:
		/// - CatalogId
		/// - Conflict information
		/// - Fragments
		/// </summary>
		/// <param name="ssIsCatalogIdNeeded"></param>
		/// <param name="ssIsConflictCheckNeeded"></param>
		/// <param name="ssAreFragmentsNeeded"></param>
		/// <param name="ssUserId"></param>
		/// <param name="ssEspaceKey"></param>
		/// <param name="ssPendingApplicationKey"></param>
		/// <param name="ssIsIsolated"></param>
		/// <param name="ssLastSolvedConflictVersion">Last version where a conflict was solved.</param>
		/// <param name="ssVersionGeneralHash">eSpace&apos;s version general hash</param>
		/// <param name="ssEspaceVersionHistory"></param>
		/// <param name="ssDBCatalogId">DBCatalogId which should be used for the next publish</param>
		/// <param name="ssVersionComparison"></param>
		/// <param name="ssFragments">Fragments used for partial upload</param>
		public void MssCompareEspaceToServerVersionForIsolated(bool ssIsCatalogIdNeeded, bool ssIsConflictCheckNeeded, bool ssAreFragmentsNeeded, int ssUserId, string ssEspaceKey, string ssPendingApplicationKey, bool ssIsIsolated, int ssLastSolvedConflictVersion, string ssVersionGeneralHash, byte[] ssEspaceVersionHistory, out int ssDBCatalogId, out RCVersionComparisonRecord ssVersionComparison, out string ssFragments) {
			ssDBCatalogId = 0;
			ssVersionComparison = new RCVersionComparisonRecord(null);
			ssFragments = "";
			// TODO: Write implementation for action
		} // MssCompareEspaceToServerVersionForIsolated

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssConfigurationsName"></param>
		public void MssServerEvents_BroadcastConfigurationsChange(string ssConfigurationsName) {
			// TODO: Write implementation for action
		} // MssServerEvents_BroadcastConfigurationsChange

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFrontendURI"></param>
		/// <param name="ssServerAPIStatus"></param>
		/// <param name="ssServerIdentityStatus"></param>
		public void MssGetServerAPIStatus(string ssFrontendURI, out string ssServerAPIStatus, out string ssServerIdentityStatus) {
			ssServerAPIStatus = "";
			ssServerIdentityStatus = "";
			// TODO: Write implementation for action
		} // MssGetServerAPIStatus

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssModules"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssCreateBuild(string ssOperationId, RLReferenceRecordList ssModules, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssCreateBuild

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		public void MssDisposeBuild(string ssOperationId) {
			// TODO: Write implementation for action
		} // MssDisposeBuild

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssInternalUsesDomainWhitelist"></param>
		/// <param name="ssWhitelist"></param>
		/// <param name="ssUpdatedBy"></param>
		/// <param name="ssUpdatedOn"></param>
		/// <param name="ssErrorText"></param>
		public void MssSaveSegmentationRuleAndDomains(bool ssInternalUsesDomainWhitelist, string ssWhitelist, int ssUpdatedBy, DateTime ssUpdatedOn, out string ssErrorText) {
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssSaveSegmentationRuleAndDomains

		/// <summary>
		/// Receives a model feature name as input and returns if that feature is available for the current environment.
		/// </summary>
		/// <param name="ssFeatureName"></param>
		/// <param name="ssIsAvailable"></param>
		public void MssIsModelFeatureAvailable(string ssFeatureName, out bool ssIsAvailable) {
			ssIsAvailable = false;
			// TODO: Write implementation for action
		} // MssIsModelFeatureAvailable

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssDependencies"></param>
		/// <param name="ssMessages"></param>
		/// <param name="ssErrorCount"></param>
		/// <param name="ssErrorText"></param>
		public void MssSetBuildDependencies(string ssOperationId, RLReferenceRecordList ssDependencies, out RLHEMessageRecordList ssMessages, out int ssErrorCount, out string ssErrorText) {
			ssMessages = new RLHEMessageRecordList();
			ssErrorCount = 0;
			ssErrorText = "";
			// TODO: Write implementation for action
		} // MssSetBuildDependencies

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssActivityId"></param>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssActivityDefinitionKey"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssResetActivityUser"></param>
		/// <param name="ssSuccess"></param>
		public void MssBPMActivityReset(int ssActivityId, string ssModuleKey, string ssActivityDefinitionKey, int ssTenantId, int ssProcessId, bool ssResetActivityUser, out bool ssSuccess) {
			ssSuccess = false;
			// TODO: Write implementation for action
		} // MssBPMActivityReset

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssActivityDefinitionKey"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssFailureMessage"></param>
		public void MssProcessResume(string ssModuleKey, string ssActivityDefinitionKey, int ssTenantId, int ssProcessId, out bool ssSuccess, out string ssFailureMessage) {
			ssSuccess = false;
			ssFailureMessage = "";
			// TODO: Write implementation for action
		} // MssProcessResume

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssActivityDefinitionKey"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssFailureMessage"></param>
		public void MssProcessTerminate(string ssModuleKey, string ssActivityDefinitionKey, int ssTenantId, int ssProcessId, out bool ssSuccess, out string ssFailureMessage) {
			ssSuccess = false;
			ssFailureMessage = "";
			// TODO: Write implementation for action
		} // MssProcessTerminate

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssActivityDefinitionKey"></param>
		/// <param name="ssTenantId"></param>
		/// <param name="ssProcessId"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssFailureMessage"></param>
		public void MssProcessSuspend(string ssModuleKey, string ssActivityDefinitionKey, int ssTenantId, int ssProcessId, out bool ssSuccess, out string ssFailureMessage) {
			ssSuccess = false;
			ssFailureMessage = "";
			// TODO: Write implementation for action
		} // MssProcessSuspend

		/// <summary>
		/// Removes the specified element from a set.
		/// </summary>
		/// <param name="ssResult">True if the element was removed. False if the element was not present.</param>
		/// <param name="ssHashSet">The set of values.</param>
		/// <param name="ssValue">The element to remove from the set.</param>
		public void MssHashSet_Remove(out bool ssResult, object ssHashSet, string ssValue) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssHashSet_Remove

		/// <summary>
		/// Initializes a new instance of the HashSet&lt;string&gt; class.
		/// </summary>
		/// <param name="ssHashSet">The set of values.</param>
		/// <param name="ssIgnoreCase">If true, case-insensitive ordinal string comparison is used. Otherwise, a case-sensitive ordinal string comparison is used.</param>
		public void MssHashSet_Create(out object ssHashSet, bool ssIgnoreCase) {
			ssHashSet = null;
			// TODO: Write implementation for action
		} // MssHashSet_Create

		/// <summary>
		/// Determines whether a set contains the specified element.
		/// </summary>
		/// <param name="ssResult">True if the set contains the specified element. Otherwise, false.</param>
		/// <param name="ssHashSet">The set of values.</param>
		/// <param name="ssValue">The set of values.</param>
		public void MssHashSet_Contains(out bool ssResult, object ssHashSet, string ssValue) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssHashSet_Contains

		/// <summary>
		/// Adds the specified element to a set.
		/// </summary>
		/// <param name="ssResult">True if the element was added. False if the element was already present.</param>
		/// <param name="ssHashSet">The set of values.</param>
		/// <param name="ssValue">The element to add to the set.</param>
		public void MssHashSet_Add(out bool ssResult, object ssHashSet, string ssValue) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssHashSet_Add

		/// <summary>
		/// Create or update a SolutionPack record with a custom timeout for the SQL operation. Useful for large solution packs.
		/// </summary>
		/// <param name="ssSource">Solution pack record.</param>
		/// <param name="ssTimeoutInMinutes">Timeout, in minutes.</param>
		/// <param name="ssOutId">Created or updated record id.</param>
		public void MssSolutionPack_CreateOrUpdate_CustomTimeout(RCSolutionPack_SCEntityRecord ssSource, int ssTimeoutInMinutes, out int ssOutId) {
			ssOutId = 0;
			// TODO: Write implementation for action
		} // MssSolutionPack_CreateOrUpdate_CustomTimeout

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssModuleKey"></param>
		/// <param name="ssResult"></param>
		public void MssModule_IsCompiledWithLastCompilerVersion(string ssModuleKey, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssModule_IsCompiledWithLastCompilerVersion

		/// <summary>
		/// Validates if the source of incoming request is the local machine and/or if it&apos;s in TrustedAddresses.
		/// </summary>
		/// <param name="ssTrustedAddresses">A comma-separated list with IP addresses or Fully Qualified Domain Names. For example: 127.0.0.1,mydomain.com</param>
		/// <param name="ssUseOnlyTrustedAddresses">If False (default), verifies if the request comes from the local machine or from one of the addresses in TrustedAddresses. Otherwise (True), validates the request source exclusively against the list of TrustedAddresses.</param>
		/// <param name="ssResult">Returns True if the request is coming from a trusted source.</param>
		/// <param name="ssRequestOrigin">The request source IP or host name.</param>
		public void MssValidateRequestSource(RLTextRecordList ssTrustedAddresses, bool ssUseOnlyTrustedAddresses, out bool ssResult, out string ssRequestOrigin) {
			ssResult = false;
			ssRequestOrigin = "";
			// TODO: Write implementation for action
		} // MssValidateRequestSource

		/// <summary>
		/// Validates an access token issued by Server.Identity to access Service Center web services and returns the user id so that Service Center can log the user in.
		/// </summary>
		/// <param name="ssAccessToken">A JWT access token issued by Server.Identity to access Service Center web services.</param>
		/// <param name="ssIsAuthorized">Whether the provided token is valid</param>
		/// <param name="ssUserId"></param>
		/// <param name="ssErrorMessage"></param>
		public void MssAuthenticateUserByAccessToken(string ssAccessToken, out bool ssIsAuthorized, out int ssUserId, out string ssErrorMessage) {
			ssIsAuthorized = false;
			ssUserId = 0;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssAuthenticateUserByAccessToken

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssInstallerId"></param>
		public void MssGetCurrentInstallerId(out string ssInstallerId) {
			ssInstallerId = "";
			// TODO: Write implementation for action
		} // MssGetCurrentInstallerId

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssLogsDir"></param>
		public void MssGetCurrentLogsDir(out string ssLogsDir) {
			ssLogsDir = "";
			// TODO: Write implementation for action
		} // MssGetCurrentLogsDir

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDateTimeUTC"></param>
		public void MssGetCurrentDateTimeUTC(out string ssDateTimeUTC) {
			ssDateTimeUTC = "";
			// TODO: Write implementation for action
		} // MssGetCurrentDateTimeUTC

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDiff"></param>
		/// <param name="ssStartDate"></param>
		/// <param name="ssEndDate"></param>
		public void MssDiffMilliseconds(out long ssDiff, string ssStartDate, string ssEndDate) {
			ssDiff = 0L;
			// TODO: Write implementation for action
		} // MssDiffMilliseconds

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssMtsiAddress"></param>
		public void MssIdentity_GetAndValidateMtsiAddress(out string ssMtsiAddress) {
			ssMtsiAddress = "";
			// TODO: Write implementation for action
		} // MssIdentity_GetAndValidateMtsiAddress

		/// <summary>
		/// Setups required stored procedures for database catalogs.
		/// </summary>
		/// <param name="ssCatalogName"></param>
		/// <param name="ssRuntimeUser"></param>
		/// <param name="ssPassword"></param>
		/// <param name="ssAdminUser"></param>
		/// <param name="ssAdminPassword"></param>
		/// <param name="ssSuccess"></param>
		/// <param name="ssErrorMessage"></param>
		public void MssSetupCatalog(string ssCatalogName, string ssRuntimeUser, string ssPassword, string ssAdminUser, string ssAdminPassword, out bool ssSuccess, out string ssErrorMessage) {
			ssSuccess = false;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssSetupCatalog

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssIsActive"></param>
		public void MssIsBuildServiceActive(out bool ssIsActive) {
			ssIsActive = false;
			// TODO: Write implementation for action
		} // MssIsBuildServiceActive

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssIsEnabled"></param>
		public void MssIsRevampedSolutionCompileEnabled(out bool ssIsEnabled) {
			ssIsEnabled = false;
			// TODO: Write implementation for action
		} // MssIsRevampedSolutionCompileEnabled

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssOperationId"></param>
		/// <param name="ssUserId"></param>
		/// <param name="ssModules"></param>
		/// <param name="ssUniqueId"></param>
		/// <param name="ssCanSkipImpactAnalysisIfRequired"></param>
		/// <param name="ssForceFirstLoad"></param>
		/// <param name="ssAllowSkipCompilation"></param>
		/// <param name="ssMessages"></param>
		public void MssBuild(string ssOperationId, int ssUserId, RLReferenceRecordList ssModules, string ssUniqueId, bool ssCanSkipImpactAnalysisIfRequired, bool ssForceFirstLoad, bool ssAllowSkipCompilation, out RLHEMessageRecordList ssMessages) {
			ssMessages = new RLHEMessageRecordList();
			// TODO: Write implementation for action
		} // MssBuild

		/// <summary>
		/// Retrieves the designated claim from the given JWT.
		/// </summary>
		/// <param name="ssClaimName">The name of the claim.</param>
		/// <param name="ssJwt">The JWT.</param>
		/// <param name="ssClaimValue">The value of the claim.</param>
		/// <param name="ssIsSuccess">Whether or not the retrieval was successful.</param>
		/// <param name="ssErrorMessage">Error message in case the retrieval was not successful.</param>
		public void MssJwtGetClaim(string ssClaimName, string ssJwt, out string ssClaimValue, out bool ssIsSuccess, out string ssErrorMessage) {
			ssClaimValue = "";
			ssIsSuccess = false;
			ssErrorMessage = "";
			// TODO: Write implementation for action
		} // MssJwtGetClaim

		/// <summary>
		/// Generates a code challenge and a code verifier to be used during an OAuth2 authorization code flow with PKCE. See the RFC for more information.
		/// </summary>
		/// <param name="ssCodeChallenge">The code challenge.</param>
		/// <param name="ssCodeVerifier">The code verifier.</param>
		public void MssGenerateCodeChallengeAndCodeVerifier(out string ssCodeChallenge, out string ssCodeVerifier) {
			ssCodeChallenge = "";
			ssCodeVerifier = "";
			// TODO: Write implementation for action
		} // MssGenerateCodeChallengeAndCodeVerifier

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssSolutionKey"></param>
		/// <param name="ssResult"></param>
		public void MssCanPublishSolution(int ssUserId, string ssSolutionKey, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssCanPublishSolution

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssConsumerEspaceKey"></param>
		/// <param name="ssConsumerEspaceVersionHash"></param>
		/// <param name="ssConsumerEspaceVersionBinary"></param>
		/// <param name="ssProducerSignatureVersions"></param>
		/// <param name="ssModulesPerDatabase"></param>
		/// <param name="ssResult"></param>
		public void MssCheckReferenceStatus(int ssUserId, string ssConsumerEspaceKey, string ssConsumerEspaceVersionHash, byte[] ssConsumerEspaceVersionBinary, RLProducerModuleSignatureRecordList ssProducerSignatureVersions, RLKeyValuePairRecordList ssModulesPerDatabase, out RCCheckReferenceStatusResultRecord ssResult) {
			ssResult = new RCCheckReferenceStatusResultRecord(null);
			// TODO: Write implementation for action
		} // MssCheckReferenceStatus

		/// <summary>
		/// Checks whether the Jwt is well-formatted (it does not perform validation).
		/// </summary>
		/// <param name="ssJwt"></param>
		/// <param name="ssResult"></param>
		public void MssIsWellFormattedJwt(string ssJwt, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssIsWellFormattedJwt

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDispatcherURL"></param>
		/// <param name="ssDispatcherSecret"></param>
		/// <param name="ssDispatcherTimeoutInMs"></param>
		public void MssAudit_GetServiceCenterConfiguration_Legacy(out string ssDispatcherURL, out string ssDispatcherSecret, out int ssDispatcherTimeoutInMs) {
			ssDispatcherURL = "";
			ssDispatcherSecret = "";
			ssDispatcherTimeoutInMs = 0;
			// TODO: Write implementation for action
		} // MssAudit_GetServiceCenterConfiguration_Legacy

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssValue"></param>
		/// <param name="ssEmptyOutputIfCannotDecrypt">If false, when it is not possible to decrypt the value an exception is thrown. If true, no exception is thrown and the output DecryptedValue is empty.</param>
		/// <param name="ssDecryptedValue"></param>
		public void MssUsersSecurity_DecryptValue(string ssValue, bool ssEmptyOutputIfCannotDecrypt, out string ssDecryptedValue) {
			ssDecryptedValue = "";
			// TODO: Write implementation for action
		} // MssUsersSecurity_DecryptValue

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssxif"></param>
		/// <param name="ssmodelFeatures"></param>
		public void MssGetExtensionModelFeatures(byte[] ssxif, out RLModuleVersionFeatureRecordList ssmodelFeatures) {
			ssmodelFeatures = new RLModuleVersionFeatureRecordList();
			// TODO: Write implementation for action
		} // MssGetExtensionModelFeatures

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssToken"></param>
		public void MssGetSearchAPIToken(out string ssToken) {
			ssToken = "";
			// TODO: Write implementation for action
		} // MssGetSearchAPIToken

		/// <summary>
		/// Gets the Authorization Endpoint from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssEndpoint"></param>
		public void MssGetAuthorizationEndpoint(string ssIdentityServiceIssuer, out string ssEndpoint) {
			ssEndpoint = "";
			// TODO: Write implementation for action
		} // MssGetAuthorizationEndpoint

		/// <summary>
		/// Gets the EndSession Endpoint from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssEndpoint"></param>
		public void MssGetEndSessionEndpoint(string ssIdentityServiceIssuer, out string ssEndpoint) {
			ssEndpoint = "";
			// TODO: Write implementation for action
		} // MssGetEndSessionEndpoint

		/// <summary>
		/// Gets the Introspection Endpoint from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssEndpoint"></param>
		public void MssGetIntrospectionEndpoint(string ssIdentityServiceIssuer, out string ssEndpoint) {
			ssEndpoint = "";
			// TODO: Write implementation for action
		} // MssGetIntrospectionEndpoint

		/// <summary>
		/// Gets the JWKS Uri from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssEndpoint"></param>
		public void MssGetJwksUri(string ssIdentityServiceIssuer, out string ssEndpoint) {
			ssEndpoint = "";
			// TODO: Write implementation for action
		} // MssGetJwksUri

		/// <summary>
		/// Gets the Token Endpoint from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssEndpoint"></param>
		public void MssGetTokenEndpoint(string ssIdentityServiceIssuer, out string ssEndpoint) {
			ssEndpoint = "";
			// TODO: Write implementation for action
		} // MssGetTokenEndpoint

		/// <summary>
		/// Gets the Userinfo Endpoint from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssEndpoint"></param>
		public void MssGetUserInfoEndpoint(string ssIdentityServiceIssuer, out string ssEndpoint) {
			ssEndpoint = "";
			// TODO: Write implementation for action
		} // MssGetUserInfoEndpoint

		/// <summary>
		/// Gets the JSON Document from the well-known/openid-configuration.
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssrawDocument"></param>
		public void MssGetWellKnownRawDocument(string ssIdentityServiceIssuer, out string ssrawDocument) {
			ssrawDocument = "";
			// TODO: Write implementation for action
		} // MssGetWellKnownRawDocument

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssUserId"></param>
		/// <param name="ssSolutionKey"></param>
		/// <param name="ssResult"></param>
		public void MssLockSolution(int ssUserId, string ssSolutionKey, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssLockSolution

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSolutionKey"></param>
		/// <param name="ssResult"></param>
		public void MssIsSolutionLocked(string ssSolutionKey, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssIsSolutionLocked

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSolutionKey"></param>
		/// <param name="ssResult"></param>
		public void MssUnlockSolution(string ssSolutionKey, out bool ssResult) {
			ssResult = false;
			// TODO: Write implementation for action
		} // MssUnlockSolution

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssValue"></param>
		/// <param name="ssResult"></param>
		public void MssSHA512Hash(string ssValue, out string ssResult) {
			ssResult = "";
			// TODO: Write implementation for action
		} // MssSHA512Hash

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssIdentityServiceIssuer"></param>
		/// <param name="ssExpectedClaim"></param>
		/// <param name="ssValid"></param>
		/// <param name="ssMessage"></param>
		public void MssOpenIdConnect_ValidateWellKnown(string ssIdentityServiceIssuer, string ssExpectedClaim, out bool ssValid, out string ssMessage) {
			ssValid = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssOpenIdConnect_ValidateWellKnown

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssToken"></param>
		/// <param name="ssIsValid"></param>
		/// <param name="ssMessage"></param>
		public void MssOpenIdConnect_ValidateToken(string ssToken, out bool ssIsValid, out string ssMessage) {
			ssIsValid = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssOpenIdConnect_ValidateToken

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSeconds"></param>
		/// <param name="ssExpires_In"></param>
		public void MssOpenIdConnect_GetDateTimeFromUnixSeconds(long ssSeconds, out DateTime ssExpires_In) {
			ssExpires_In = new DateTime(1900, 1, 1, 0, 0, 0);
			// TODO: Write implementation for action
		} // MssOpenIdConnect_GetDateTimeFromUnixSeconds

		/// <summary>
		/// 
		/// </summary>
		public void MssOpenIdConnect_ClearTokenSession() {
			// TODO: Write implementation for action
		} // MssOpenIdConnect_ClearTokenSession

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssExpiration"></param>
		public void MssOpenIdConnect_GetExpiration(out DateTime ssExpiration) {
			ssExpiration = new DateTime(1900, 1, 1, 0, 0, 0);
			// TODO: Write implementation for action
		} // MssOpenIdConnect_GetExpiration

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssClientId"></param>
		public void MssOpenIdConnect_GetClientId(out string ssClientId) {
			ssClientId = "";
			// TODO: Write implementation for action
		} // MssOpenIdConnect_GetClientId

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssToken"></param>
		public void MssOpenIdConnect_GetRefreshToken(out string ssToken) {
			ssToken = "";
			// TODO: Write implementation for action
		} // MssOpenIdConnect_GetRefreshToken

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssToken"></param>
		public void MssOpenIdConnect_GetAccessToken(out string ssToken) {
			ssToken = "";
			// TODO: Write implementation for action
		} // MssOpenIdConnect_GetAccessToken

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssToken"></param>
		/// <param name="ssIsValid"></param>
		/// <param name="ssIsLoginSSO"></param>
		/// <param name="ssMessage"></param>
		public void MssOpenIdConnect_GetIdToken(out string ssToken, out bool ssIsValid, out bool ssIsLoginSSO, out string ssMessage) {
			ssToken = "";
			ssIsValid = false;
			ssIsLoginSSO = false;
			ssMessage = "";
			// TODO: Write implementation for action
		} // MssOpenIdConnect_GetIdToken

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssAccessToken"></param>
		/// <param name="ssIdToken"></param>
		/// <param name="ssRefreshToken"></param>
		/// <param name="ssClientId"></param>
		/// <param name="ssExpires_In"></param>
		/// <param name="ssLoginFlow"></param>
		public void MssOpenIdConnect_SaveTokens(string ssAccessToken, string ssIdToken, string ssRefreshToken, string ssClientId, DateTime ssExpires_In, string ssLoginFlow) {
			// TODO: Write implementation for action
		} // MssOpenIdConnect_SaveTokens

	} // CssOMLProcessor

} // OutSystems.NssOMLProcessor

