using System;

namespace marketingcloudsdkIOS
{
    [Native]
    public enum pushOriginationState : ulong
    {
        firstPushOriginationStateIndex = 0,
        PushOriginationStateBackground = firstPushOriginationStateIndex,
        PushOriginationStateForeground,
        PushOriginationStateUnknown = 999,
        lastPushOriginationStateIndex = PushOriginationStateUnknown
    }

    [Native]
    public enum configureSDKWithAppIDError : ulong
    {
        firstconfigureSDKWithAppIDIndex = 0,
        configureSDKWithAppIDNoError = firstconfigureSDKWithAppIDIndex,
        configureSDKWithAppIDInvalidAppIDError,
        configureSDKWithAppIDInvalidAccessTokenError,
        configureSDKWithAppIDUnableToReadRandomError,
        configureSDKWithAppIDDatabaseAccessError,
        configureSDKWithAppIDUnableToKeyDatabaseError,
        configureSDKWithAppIDCCKeyDerivationPBKDFError,
        configureSDKWithAppIDCCSymmetricKeyWrapError,
        configureSDKWithAppIDCCSymmetricKeyUnwrapError,
        configureSDKWithAppIDKeyChainError,
        configureSDKWithAppIDUnableToReadCertificateError,
        configureSDKWithAppIDRunOnceSimultaneouslyError,
        configureSDKWithAppIDRunOnceError,
        configureSDKWithAppIDInvalidLocationAndProximityError,
        configureSDKWithAppIDSimulatorBlobError,
        configureSDKWithAppIDKeyChainInvalidError,
        lastconfigureSDKWithAppIDIndex = configureSDKWithAppIDKeyChainInvalidError
    }

    [Native]
    public enum requestPIRecommendationsError : ulong
    {
        firstrequestPIRecommendationsInvalidIndex = 0,
        requestPIRecommendationsNoError = firstrequestPIRecommendationsInvalidIndex,
        requestPIRecommendationsInvalidMidParameterError = 1024,
        requestPIRecommendationsInvalidRetailerParameterError,
        requestPIRecommendationsInvalidPageParameterError,
        requestPIRecommendationsInvalidCompletionHandlerError,
        lastrequestPIRecommendationsInvalidIndex = requestPIRecommendationsInvalidCompletionHandlerError
    }

    [Native]
    public enum MobilePushMessageType : ulong
    {
        firstMobilePushMessageTypeIndex = 0,
        MobilePushMessageTypeUnknown = firstMobilePushMessageTypeIndex,
        MobilePushMessageTypeBasic,
        MobilePushMessageTypeFenceEntry = 3,
        MobilePushMessageTypeFenceExit,
        MobilePushMessageTypeProximity,
        MobilePushMessageTypeSilentPush,
        MobilePushMessageTypeInbox = 8,
        lastMobilePushMessageTypeIndex = MobilePushMessageTypeInbox
    }

    [Native]
    public enum MobilePushGeofenceType : ulong
    {
        firstMobilePushGeofenceTypeIndex = 0,
        MobilePushGeofenceTypeNone = firstMobilePushGeofenceTypeIndex,
        MobilePushGeofenceTypeCircle,
        MobilePushGeofenceTypeProximity = 3,
        lastMobilePushGeofenceTypeIndex = MobilePushGeofenceTypeProximity
    }

    [Native]
    public enum ETRegionRequestType : ulong
    {
        firstETRegionRequestTypeProximityIndex = 0,
        ETRegionRequestTypeUnknown = firstETRegionRequestTypeProximityIndex,
        ETRegionRequestTypeGeofence,
        ETRegionRequestTypeProximity,
        lastETRegionRequestTypeProximityIndex = ETRegionRequestTypeProximity
    }

    [Native]
    public enum MobilePushContentType : long
    {
        None = 0,
        AlertMessage = 1 << 0,
        Page = 1 << 1,
        Ecp = 1 << 31
    }

    [Native]
    public enum MobilePushMessageFrequencyUnit : ulong
    {
        firstMobilePushMessageFrequencyIndex = 0,
        MobilePushMessageFrequencyUnitNone = firstMobilePushMessageFrequencyIndex,
        MobilePushMessageFrequencyUnitYear,
        MobilePushMessageFrequencyUnitMonth,
        MobilePushMessageFrequencyUnitWeek,
        MobilePushMessageFrequencyUnitDay,
        MobilePushMessageFrequencyUnitHour,
        lastMobilePushMessageFrequencyIndex = MobilePushMessageFrequencyUnitHour
    }

    [Native]
    public enum GenericUpdateSendMethod : long
    {
        firstGenericUpdateSendMethodDeleteIndex = 0,
        GenericUpdateSendMethodGet = firstGenericUpdateSendMethodDeleteIndex,
        GenericUpdateSendMethodPost,
        GenericUpdateSendMethodPut,
        GenericUpdateSendMethodDelete,
        lastGenericUpdateSendMethodDeleteIndex = GenericUpdateSendMethodDelete
    }

    [Native]
    public enum LocationUpdateAppState : long
    {
        firstLocationUpdateAppStateIndex = 0,
        LocationUpdateAppStateBackground = firstLocationUpdateAppStateIndex,
        LocationUpdateAppStateForeground,
        lastLocationUpdateAppStateIndex = LocationUpdateAppStateForeground
    }
}
