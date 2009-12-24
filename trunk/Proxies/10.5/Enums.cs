//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
namespace NObjective.Proxies {
	public enum NSAlertStyle {
		NSCriticalAlertStyle = 2,
		NSInformationalAlertStyle = 1,
		NSWarningAlertStyle = 0
	}
	public enum NSAnimationBlockingMode {
		NSAnimationBlocking = 0,
		NSAnimationNonblocking = 1,
		NSAnimationNonblockingThreaded = 2
	}
	public enum NSAnimationCurve {
		NSAnimationEaseIn = 1,
		NSAnimationEaseInOut = 0,
		NSAnimationEaseOut = 2,
		NSAnimationLinear = 3
	}
	public enum NSAnimationEffect {
		NSAnimationEffectDisappearingItemDefault = 0,
		NSAnimationEffectPoof = 10
	}
	public enum NSApplicationPrintReply {
		NSPrintingCancelled = 0,
		NSPrintingFailure = 3,
		NSPrintingReplyLater = 2,
		NSPrintingSuccess = 1
	}
	public enum NSApplicationTerminateReply {
		NSTerminateCancel = 0,
		NSTerminateLater = 2,
		NSTerminateNow = 1
	}
	public enum NSAttributeType {
		NSBinaryDataAttributeType = 1000,
		NSBooleanAttributeType = 800,
		NSDateAttributeType = 900,
		NSDecimalAttributeType = 400,
		NSDoubleAttributeType = 500,
		NSFloatAttributeType = 600,
		NSInteger16AttributeType = 100,
		NSInteger32AttributeType = 200,
		NSInteger64AttributeType = 300,
		NSStringAttributeType = 700,
		NSTransformableAttributeType = 1800,
		NSUndefinedAttributeType = 0
	}
	public enum NSBackingStoreType {
		NSBackingStoreBuffered = 2,
		NSBackingStoreNonretained = 1,
		NSBackingStoreRetained = 0
	}
	public enum NSBezelStyle {
		NSCircularBezelStyle = 7,
		NSDisclosureBezelStyle = 5,
		NSHelpButtonBezelStyle = 9,
		NSRecessedBezelStyle = 13,
		NSRegularSquareBezelStyle = 2,
		NSRoundedBezelStyle = 1,
		NSRoundedDisclosureBezelStyle = 14,
		NSRoundRectBezelStyle = 12,
		NSShadowlessSquareBezelStyle = 6,
		NSSmallIconButtonBezelStyle = 2,
		NSSmallSquareBezelStyle = 10,
		NSTexturedRoundedBezelStyle = 11,
		NSTexturedSquareBezelStyle = 8,
		NSThickerSquareBezelStyle = 4,
		NSThickSquareBezelStyle = 3
	}
	public enum NSBezierPathElement {
		NSClosePathBezierPathElement = 3,
		NSCurveToBezierPathElement = 2,
		NSLineToBezierPathElement = 1,
		NSMoveToBezierPathElement = 0
	}
	public enum NSBitmapFormat {
		NSAlphaFirstBitmapFormat = 1,
		NSAlphaNonpremultipliedBitmapFormat = 2,
		NSFloatingPointSamplesBitmapFormat = 4
	}
	public enum NSBitmapImageFileType {
		NSBMPFileType = 1,
		NSGIFFileType = 2,
		NSJPEG2000FileType = 5,
		NSJPEGFileType = 3,
		NSPNGFileType = 4,
		NSTIFFFileType = 0
	}
	public enum NSBorderType {
		NSBezelBorder = 2,
		NSGrooveBorder = 3,
		NSLineBorder = 1,
		NSNoBorder = 0
	}
	public enum NSBoxType {
		NSBoxCustom = 4,
		NSBoxOldStyle = 3,
		NSBoxPrimary = 0,
		NSBoxSecondary = 1,
		NSBoxSeparator = 2
	}
	public enum NSBrowserColumnResizingType {
		NSBrowserAutoColumnResizing = 1,
		NSBrowserNoColumnResizing = 0,
		NSBrowserUserColumnResizing = 2
	}
	public enum NSBrowserDropOperation {
		NSBrowserDropAbove = 1,
		NSBrowserDropOn = 0
	}
	public enum NSButtonType {
		NSMomentaryChangeButton = 5,
		NSMomentaryLight = 7,
		NSMomentaryLightButton = 0,
		NSMomentaryPushButton = 0,
		NSMomentaryPushInButton = 7,
		NSOnOffButton = 6,
		NSPushOnPushOffButton = 1,
		NSRadioButton = 4,
		NSSwitchButton = 3,
		NSToggleButton = 2
	}
	public enum NSCalculationError {
		NSCalculationDivideByZero = 4,
		NSCalculationLossOfPrecision = 1,
		NSCalculationNoError = 0,
		NSCalculationOverflow = 3,
		NSCalculationUnderflow = 2
	}
	public enum NSCalendarUnit {
		NSDayCalendarUnit = 16,
		NSEraCalendarUnit = 2,
		NSHourCalendarUnit = 32,
		NSMinuteCalendarUnit = 64,
		NSMonthCalendarUnit = 8,
		NSSecondCalendarUnit = 128,
		NSWeekCalendarUnit = 256,
		NSWeekdayCalendarUnit = 512,
		NSWeekdayOrdinalCalendarUnit = 1024,
		NSYearCalendarUnit = 4
	}
	public enum NSCellAttribute {
		NSCellAllowsMixedState = 16,
		NSCellChangesContents = 14,
		NSCellDisabled = 0,
		NSCellEditable = 3,
		NSCellHasImageHorizontal = 12,
		NSCellHasImageOnLeftOrBottom = 13,
		NSCellHasOverlappingImage = 11,
		NSCellHighlighted = 5,
		NSCellIsBordered = 10,
		NSCellIsInsetButton = 15,
		NSCellLightsByBackground = 9,
		NSCellLightsByContents = 6,
		NSCellLightsByGray = 7,
		NSCellState = 1,
		NSChangeBackgroundCell = 8,
		NSChangeGrayCell = 4,
		NSPushInCell = 2
	}
	public enum NSCellImagePosition {
		NSImageAbove = 5,
		NSImageBelow = 4,
		NSImageLeft = 2,
		NSImageOnly = 1,
		NSImageOverlaps = 6,
		NSImageRight = 3,
		NSNoImage = 0
	}
	public enum NSCellType {
		NSImageCellType = 2,
		NSNullCellType = 0,
		NSTextCellType = 1
	}
	public enum NSCharacterCollection {
		NSAdobeCNS1CharacterCollection = 1,
		NSAdobeGB1CharacterCollection = 2,
		NSAdobeJapan1CharacterCollection = 3,
		NSAdobeJapan2CharacterCollection = 4,
		NSAdobeKorea1CharacterCollection = 5,
		NSIdentityMappingCharacterCollection = 0
	}
	public enum NSComparisonPredicateModifier {
		NSAllPredicateModifier = 1,
		NSAnyPredicateModifier = 2,
		NSDirectPredicateModifier = 0
	}
	public enum NSCompositingOperation {
		NSCompositeClear = 0,
		NSCompositeCopy = 1,
		NSCompositeDestinationAtop = 9,
		NSCompositeDestinationIn = 7,
		NSCompositeDestinationOut = 8,
		NSCompositeDestinationOver = 6,
		NSCompositeHighlight = 12,
		NSCompositePlusDarker = 11,
		NSCompositePlusLighter = 13,
		NSCompositeSourceAtop = 5,
		NSCompositeSourceIn = 3,
		NSCompositeSourceOut = 4,
		NSCompositeSourceOver = 2,
		NSCompositeXOR = 10
	}
	public enum NSCompoundPredicateType {
		NSAndPredicateType = 1,
		NSNotPredicateType = 0,
		NSOrPredicateType = 2
	}
	public enum NSControlSize {
		NSMiniControlSize = 2,
		NSRegularControlSize = 0,
		NSSmallControlSize = 1
	}
	public enum NSControlTint {
		NSBlueControlTint = 1,
		NSClearControlTint = 7,
		NSDefaultControlTint = 0,
		NSGraphiteControlTint = 6
	}
	public enum NSDatePickerMode {
		NSRangeDateMode = 1,
		NSSingleDateMode = 0
	}
	public enum NSDatePickerStyle {
		NSClockAndCalendarDatePickerStyle = 1,
		NSTextFieldAndStepperDatePickerStyle = 0,
		NSTextFieldDatePickerStyle = 2
	}
	public enum NSDeleteRule {
		NSCascadeDeleteRule = 2,
		NSDenyDeleteRule = 3,
		NSNoActionDeleteRule = 0,
		NSNullifyDeleteRule = 1
	}
	public enum NSDocumentChangeType {
		NSChangeAutosaved = 4,
		NSChangeCleared = 2,
		NSChangeDone = 0,
		NSChangeReadOtherContents = 3,
		NSChangeRedone = 5,
		NSChangeUndone = 1
	}
	public enum NSDrawerState {
		NSDrawerClosedState = 0,
		NSDrawerClosingState = 3,
		NSDrawerOpeningState = 1,
		NSDrawerOpenState = 2
	}
	public enum NSEntityMappingType {
		NSAddEntityMappingType = 2,
		NSCopyEntityMappingType = 4,
		NSCustomEntityMappingType = 1,
		NSRemoveEntityMappingType = 3,
		NSTransformEntityMappingType = 5,
		NSUndefinedEntityMappingType = 0
	}
	public enum NSEventType {
		NSAppKitDefined = 13,
		NSApplicationDefined = 15,
		NSCursorUpdate = 17,
		NSFlagsChanged = 12,
		NSKeyDown = 10,
		NSKeyUp = 11,
		NSLeftMouseDown = 1,
		NSLeftMouseDragged = 6,
		NSLeftMouseUp = 2,
		NSMouseEntered = 8,
		NSMouseExited = 9,
		NSMouseMoved = 5,
		NSOtherMouseDown = 25,
		NSOtherMouseDragged = 27,
		NSOtherMouseUp = 26,
		NSPeriodic = 16,
		NSRightMouseDown = 3,
		NSRightMouseDragged = 7,
		NSRightMouseUp = 4,
		NSScrollWheel = 22,
		NSSystemDefined = 14,
		NSTabletPoint = 23,
		NSTabletProximity = 24
	}
	public enum NSExpressionType {
		NSAggregateExpressionType = 14,
		NSConstantValueExpressionType = 0,
		NSEvaluatedObjectExpressionType = 1,
		NSFunctionExpressionType = 4,
		NSIntersectSetExpressionType = 6,
		NSKeyPathExpressionType = 3,
		NSMinusSetExpressionType = 7,
		NSSubqueryExpressionType = 13,
		NSUnionSetExpressionType = 5,
		NSVariableExpressionType = 2
	}
	public enum NSFindPanelAction {
		NSFindPanelActionNext = 2,
		NSFindPanelActionPrevious = 3,
		NSFindPanelActionReplace = 5,
		NSFindPanelActionReplaceAll = 4,
		NSFindPanelActionReplaceAllInSelection = 8,
		NSFindPanelActionReplaceAndFind = 6,
		NSFindPanelActionSelectAll = 9,
		NSFindPanelActionSelectAllInSelection = 10,
		NSFindPanelActionSetFindString = 7,
		NSFindPanelActionShowFindPanel = 1
	}
	public enum NSFindPanelSubstringMatchType {
		NSFindPanelSubstringMatchTypeContains = 0,
		NSFindPanelSubstringMatchTypeEndsWith = 3,
		NSFindPanelSubstringMatchTypeFullWord = 2,
		NSFindPanelSubstringMatchTypeStartsWith = 1
	}
	public enum NSFocusRingPlacement {
		NSFocusRingAbove = 2,
		NSFocusRingBelow = 1,
		NSFocusRingOnly = 0
	}
	public enum NSFocusRingType {
		NSFocusRingTypeDefault = 0,
		NSFocusRingTypeExterior = 2,
		NSFocusRingTypeNone = 1
	}
	public enum NSFontAction {
		NSAddTraitFontAction = 2,
		NSHeavierFontAction = 5,
		NSLighterFontAction = 6,
		NSNoFontChangeAction = 0,
		NSRemoveTraitFontAction = 7,
		NSSizeDownFontAction = 4,
		NSSizeUpFontAction = 3,
		NSViaPanelFontAction = 1
	}
	public enum NSFontRenderingMode {
		NSFontAntialiasedIntegerAdvancementsRenderingMode = 3,
		NSFontAntialiasedRenderingMode = 1,
		NSFontDefaultRenderingMode = 0,
		NSFontIntegerAdvancementsRenderingMode = 2
	}
	public enum NSGlyphInscription {
		NSGlyphInscribeAbove = 2,
		NSGlyphInscribeBase = 0,
		NSGlyphInscribeBelow = 1,
		NSGlyphInscribeOverBelow = 4,
		NSGlyphInscribeOverstrike = 3
	}
	public enum NSGradientType {
		NSGradientConcaveStrong = 2,
		NSGradientConcaveWeak = 1,
		NSGradientConvexStrong = 4,
		NSGradientConvexWeak = 3,
		NSGradientNone = 0
	}
	public enum NSHashTableOptions {
		NSHashTableCopyIn = 65536,
		NSHashTableObjectPointerPersonality = 512,
		NSHashTableStrongMemory = 0,
		NSHashTableZeroingWeakMemory = 1
	}
	public enum NSHTTPCookieAcceptPolicy {
		NSHTTPCookieAcceptPolicyAlways = 0,
		NSHTTPCookieAcceptPolicyNever = 1,
		NSHTTPCookieAcceptPolicyOnlyFromMainDocumentDomain = 2
	}
	public enum NSImageAlignment {
		NSImageAlignBottom = 5,
		NSImageAlignBottomLeft = 6,
		NSImageAlignBottomRight = 7,
		NSImageAlignCenter = 0,
		NSImageAlignLeft = 4,
		NSImageAlignRight = 8,
		NSImageAlignTop = 1,
		NSImageAlignTopLeft = 2,
		NSImageAlignTopRight = 3
	}
	public enum NSImageCacheMode {
		NSImageCacheAlways = 1,
		NSImageCacheBySize = 2,
		NSImageCacheDefault = 0,
		NSImageCacheNever = 3
	}
	public enum NSImageFrameStyle {
		NSImageFrameButton = 4,
		NSImageFrameGrayBezel = 2,
		NSImageFrameGroove = 3,
		NSImageFrameNone = 0,
		NSImageFramePhoto = 1
	}
	public enum NSImageInterpolation {
		NSImageInterpolationDefault = 0,
		NSImageInterpolationHigh = 3,
		NSImageInterpolationLow = 2,
		NSImageInterpolationNone = 1
	}
	public enum NSImageLoadStatus {
		NSImageLoadStatusCancelled = 1,
		NSImageLoadStatusCompleted = 0,
		NSImageLoadStatusInvalidData = 2,
		NSImageLoadStatusReadError = 4,
		NSImageLoadStatusUnexpectedEOF = 3
	}
	public enum NSImageScaling {
		NSImageScaleAxesIndependently = 1,
		NSImageScaleNone = 2,
		NSImageScaleProportionallyDown = 0,
		NSImageScaleProportionallyUpOrDown = 3
	}
	public enum NSInsertionPosition {
		NSPositionAfter = 0,
		NSPositionBefore = 1,
		NSPositionBeginning = 2,
		NSPositionEnd = 3,
		NSPositionReplace = 4
	}
	public enum NSInterfaceStyle {
		NSMacintoshInterfaceStyle = 3,
		NSNextStepInterfaceStyle = 1,
		NSNoInterfaceStyle = 0,
		NSWindows95InterfaceStyle = 2
	}
	public enum NSKeyValueChange {
		NSKeyValueChangeInsertion = 2,
		NSKeyValueChangeRemoval = 3,
		NSKeyValueChangeReplacement = 4,
		NSKeyValueChangeSetting = 1
	}
	public enum NSKeyValueObservingOptions {
		NSKeyValueObservingOptionInitial = 4,
		NSKeyValueObservingOptionNew = 1,
		NSKeyValueObservingOptionOld = 2,
		NSKeyValueObservingOptionPrior = 8
	}
	public enum NSKeyValueSetMutationKind {
		NSKeyValueIntersectSetMutation = 3,
		NSKeyValueMinusSetMutation = 2,
		NSKeyValueSetSetMutation = 4,
		NSKeyValueUnionSetMutation = 1
	}
	public enum NSLevelIndicatorStyle {
		NSContinuousCapacityLevelIndicatorStyle = 1,
		NSDiscreteCapacityLevelIndicatorStyle = 2,
		NSRatingLevelIndicatorStyle = 3,
		NSRelevancyLevelIndicatorStyle = 0
	}
	public enum NSLineBreakMode {
		NSLineBreakByCharWrapping = 1,
		NSLineBreakByClipping = 2,
		NSLineBreakByTruncatingHead = 3,
		NSLineBreakByTruncatingMiddle = 5,
		NSLineBreakByTruncatingTail = 4,
		NSLineBreakByWordWrapping = 0
	}
	public enum NSLineCapStyle {
		NSButtLineCapStyle = 0,
		NSRoundLineCapStyle = 1,
		NSSquareLineCapStyle = 2
	}
	public enum NSLineJoinStyle {
		NSBevelLineJoinStyle = 2,
		NSMiterLineJoinStyle = 0,
		NSRoundLineJoinStyle = 1
	}
	public enum NSLineMovementDirection {
		NSLineDoesntMove = 0,
		NSLineMovesDown = 3,
		NSLineMovesLeft = 1,
		NSLineMovesRight = 2,
		NSLineMovesUp = 4
	}
	public enum NSLineSweepDirection {
		NSLineSweepDown = 2,
		NSLineSweepLeft = 0,
		NSLineSweepRight = 1,
		NSLineSweepUp = 3
	}
	public enum NSMapTableOptions {
		NSMapTableCopyIn = 65536,
		NSMapTableObjectPointerPersonality = 512,
		NSMapTableStrongMemory = 0,
		NSMapTableZeroingWeakMemory = 1
	}
	public enum NSMatrixMode {
		NSHighlightModeMatrix = 1,
		NSListModeMatrix = 2,
		NSRadioModeMatrix = 0,
		NSTrackModeMatrix = 3
	}
	public enum NSMultibyteGlyphPacking {
		NSNativeShortGlyphPacking = 5
	}
	public enum NSNetServiceOptions {
		NSNetServiceNoAutoRename = 1
	}
	public enum NSNotificationCoalescing {
		NSNotificationCoalescingOnName = 1,
		NSNotificationCoalescingOnSender = 2,
		NSNotificationNoCoalescing = 0
	}
	public enum NSNotificationSuspensionBehavior {
		NSNotificationSuspensionBehaviorCoalesce = 2,
		NSNotificationSuspensionBehaviorDeliverImmediately = 4,
		NSNotificationSuspensionBehaviorDrop = 1,
		NSNotificationSuspensionBehaviorHold = 3
	}
	public enum NSOpenGLContextParameter {
		NSOpenGLCPRasterizationEnable = 221,
		NSOpenGLCPStateValidation = 301,
		NSOpenGLCPSurfaceOpacity = 236,
		NSOpenGLCPSurfaceOrder = 235,
		NSOpenGLCPSwapInterval = 222,
		NSOpenGLCPSwapRectangle = 200,
		NSOpenGLCPSwapRectangleEnable = 201
	}
	public enum NSPointerFunctionsOptions {
		NSPointerFunctionsCopyIn = 65536,
		NSPointerFunctionsCStringPersonality = 768,
		NSPointerFunctionsIntegerPersonality = 1280,
		NSPointerFunctionsMachVirtualMemory = 4,
		NSPointerFunctionsMallocMemory = 3,
		NSPointerFunctionsObjectPersonality = 0,
		NSPointerFunctionsObjectPointerPersonality = 512,
		NSPointerFunctionsOpaqueMemory = 2,
		NSPointerFunctionsOpaquePersonality = 256,
		NSPointerFunctionsStrongMemory = 0,
		NSPointerFunctionsStructPersonality = 1024,
		NSPointerFunctionsZeroingWeakMemory = 1
	}
	public enum NSPointingDeviceType {
		NSCursorPointingDevice = 2,
		NSEraserPointingDevice = 3,
		NSPenPointingDevice = 1,
		NSUnknownPointingDevice = 0
	}
	public enum NSPopUpArrowPosition {
		NSPopUpArrowAtBottom = 2,
		NSPopUpArrowAtCenter = 1,
		NSPopUpNoArrow = 0
	}
	public enum NSPostingStyle {
		NSPostASAP = 2,
		NSPostNow = 3,
		NSPostWhenIdle = 1
	}
	public enum NSPredicateOperatorType {
		NSBeginsWithPredicateOperatorType = 8,
		NSBetweenPredicateOperatorType = 100,
		NSContainsPredicateOperatorType = 99,
		NSCustomSelectorPredicateOperatorType = 11,
		NSEndsWithPredicateOperatorType = 9,
		NSEqualToPredicateOperatorType = 4,
		NSGreaterThanOrEqualToPredicateOperatorType = 3,
		NSGreaterThanPredicateOperatorType = 2,
		NSInPredicateOperatorType = 10,
		NSLessThanOrEqualToPredicateOperatorType = 1,
		NSLessThanPredicateOperatorType = 0,
		NSLikePredicateOperatorType = 7,
		NSMatchesPredicateOperatorType = 6,
		NSNotEqualToPredicateOperatorType = 5
	}
	public enum NSPrinterTableStatus {
		NSPrinterTableError = 2,
		NSPrinterTableNotFound = 1,
		NSPrinterTableOK = 0
	}
	public enum NSPrintingOrientation {
		NSLandscapeOrientation = 1,
		NSPortraitOrientation = 0
	}
	public enum NSPrintingPaginationMode {
		NSAutoPagination = 0,
		NSClipPagination = 2,
		NSFitPagination = 1
	}
	public enum NSProgressIndicatorStyle {
		NSProgressIndicatorBarStyle = 0,
		NSProgressIndicatorSpinningStyle = 1
	}
	public enum NSProgressIndicatorThickness {
		NSProgressIndicatorPreferredAquaThickness = 12,
		NSProgressIndicatorPreferredLargeThickness = 18,
		NSProgressIndicatorPreferredSmallThickness = 10,
		NSProgressIndicatorPreferredThickness = 14
	}
	public enum NSPropertyListFormat {
		NSPropertyListBinaryFormat_v1_0 = 200,
		NSPropertyListOpenStepFormat = 1,
		NSPropertyListXMLFormat_v1_0 = 100
	}
	public enum NSPropertyListMutabilityOptions {
		NSPropertyListImmutable = 0,
		NSPropertyListMutableContainers = 1,
		NSPropertyListMutableContainersAndLeaves = 2
	}
	public enum NSQTMovieLoopMode {
		NSQTMovieLoopingBackAndForthPlayback = 2,
		NSQTMovieLoopingPlayback = 1,
		NSQTMovieNormalPlayback = 0
	}
	public enum NSRectEdge {
		NSMaxXEdge = 2,
		NSMaxYEdge = 3,
		NSMinXEdge = 0,
		NSMinYEdge = 1
	}
	public enum NSRelativePosition {
		NSRelativeAfter = 0,
		NSRelativeBefore = 1
	}
	public enum NSRoundingMode {
		NSRoundBankers = 3,
		NSRoundDown = 1,
		NSRoundPlain = 0,
		NSRoundUp = 2
	}
	public enum NSRuleEditorNestingMode {
		NSRuleEditorNestingModeCompound = 2,
		NSRuleEditorNestingModeList = 1,
		NSRuleEditorNestingModeSimple = 3,
		NSRuleEditorNestingModeSingle = 0
	}
	public enum NSRuleEditorRowType {
		NSRuleEditorRowTypeCompound = 1,
		NSRuleEditorRowTypeSimple = 0
	}
	public enum NSRulerOrientation {
		NSHorizontalRuler = 0,
		NSVerticalRuler = 1
	}
	public enum NSSaveOperationType {
		NSAutosaveOperation = 3,
		NSSaveAsOperation = 1,
		NSSaveOperation = 0,
		NSSaveToOperation = 2
	}
	public enum NSSaveOptions {
		NSSaveOptionsAsk = 2,
		NSSaveOptionsNo = 1,
		NSSaveOptionsYes = 0
	}
	public enum NSScrollArrowPosition {
		NSScrollerArrowsDefaultSetting = 0,
		NSScrollerArrowsMaxEnd = 0,
		NSScrollerArrowsMinEnd = 1,
		NSScrollerArrowsNone = 2
	}
	public enum NSScrollerArrow {
		NSScrollerDecrementArrow = 1,
		NSScrollerIncrementArrow = 0
	}
	public enum NSScrollerPart {
		NSScrollerDecrementLine = 4,
		NSScrollerDecrementPage = 1,
		NSScrollerIncrementLine = 5,
		NSScrollerIncrementPage = 3,
		NSScrollerKnob = 2,
		NSScrollerKnobSlot = 6,
		NSScrollerNoPart = 0
	}
	public enum NSSearchPathDirectory {
		NSAdminApplicationDirectory = 4,
		NSAllApplicationsDirectory = 100,
		NSAllLibrariesDirectory = 101,
		NSApplicationDirectory = 1,
		NSApplicationSupportDirectory = 14,
		NSCachesDirectory = 13,
		NSCoreServiceDirectory = 10,
		NSDemoApplicationDirectory = 2,
		NSDesktopDirectory = 12,
		NSDeveloperApplicationDirectory = 3,
		NSDeveloperDirectory = 6,
		NSDocumentationDirectory = 8,
		NSDocumentDirectory = 9,
		NSDownloadsDirectory = 15,
		NSLibraryDirectory = 5,
		NSUserDirectory = 7
	}
	public enum NSSearchPathDomainMask {
		NSAllDomainsMask = 65535,
		NSLocalDomainMask = 2,
		NSNetworkDomainMask = 4,
		NSSystemDomainMask = 8,
		NSUserDomainMask = 1
	}
	public enum NSSegmentSwitchTracking {
		NSSegmentSwitchTrackingMomentary = 2,
		NSSegmentSwitchTrackingSelectAny = 1,
		NSSegmentSwitchTrackingSelectOne = 0
	}
	public enum NSSelectionAffinity {
		NSSelectionAffinityDownstream = 1,
		NSSelectionAffinityUpstream = 0
	}
	public enum NSSelectionDirection {
		NSDirectSelection = 0,
		NSSelectingNext = 1,
		NSSelectingPrevious = 2
	}
	public enum NSSelectionGranularity {
		NSSelectByCharacter = 0,
		NSSelectByParagraph = 2,
		NSSelectByWord = 1
	}
	public enum NSSliderType {
		NSCircularSlider = 1,
		NSLinearSlider = 0
	}
	public enum NSSpeechBoundary {
		NSSpeechImmediateBoundary = 0,
		NSSpeechSentenceBoundary = 2,
		NSSpeechWordBoundary = 1
	}
	public enum NSStreamEvent {
		NSStreamEventEndEncountered = 16,
		NSStreamEventErrorOccurred = 8,
		NSStreamEventHasBytesAvailable = 2,
		NSStreamEventHasSpaceAvailable = 4,
		NSStreamEventNone = 0,
		NSStreamEventOpenCompleted = 1
	}
	public enum NSStreamStatus {
		NSStreamStatusAtEnd = 5,
		NSStreamStatusClosed = 6,
		NSStreamStatusError = 7,
		NSStreamStatusNotOpen = 0,
		NSStreamStatusOpen = 2,
		NSStreamStatusOpening = 1,
		NSStreamStatusReading = 3,
		NSStreamStatusWriting = 4
	}
	public enum NSStringCompareOptions {
		NSAnchoredSearch = 8,
		NSBackwardsSearch = 4,
		NSCaseInsensitiveSearch = 1,
		NSDiacriticInsensitiveSearch = 128,
		NSForcedOrderingSearch = 512,
		NSLiteralSearch = 2,
		NSNumericSearch = 64,
		NSWidthInsensitiveSearch = 256
	}
	public enum NSStringEncoding {
		NSASCIIStringEncoding = 1,
		NSISO2022JPStringEncoding = 21,
		NSISOLatin1StringEncoding = 5,
		NSISOLatin2StringEncoding = 9,
		NSJapaneseEUCStringEncoding = 3,
		NSMacOSRomanStringEncoding = 30,
		NSNEXTSTEPStringEncoding = 2,
		NSNonLossyASCIIStringEncoding = 7,
		NSShiftJISStringEncoding = 8,
		NSSymbolStringEncoding = 6,
		NSUnicodeStringEncoding = 10,
		NSUTF16BigEndianStringEncoding = -1879047936,
		NSUTF16LittleEndianStringEncoding = -1811939072,
		NSUTF16StringEncoding = 10,
		NSUTF32BigEndianStringEncoding = -1744830208,
		NSUTF32LittleEndianStringEncoding = -1677721344,
		NSUTF32StringEncoding = -1946156800,
		NSUTF8StringEncoding = 4,
		NSWindowsCP1250StringEncoding = 15,
		NSWindowsCP1251StringEncoding = 11,
		NSWindowsCP1252StringEncoding = 12,
		NSWindowsCP1253StringEncoding = 13,
		NSWindowsCP1254StringEncoding = 14
	}
	public enum NSStringEncodingConversionOptions {
		NSStringEncodingConversionAllowLossy = 1,
		NSStringEncodingConversionExternalRepresentation = 2
	}
	public enum NSTableViewDropOperation {
		NSTableViewDropAbove = 1,
		NSTableViewDropOn = 0
	}
	public enum NSTabState {
		NSBackgroundTab = 1,
		NSPressedTab = 2,
		NSSelectedTab = 0
	}
	public enum NSTabViewType {
		NSBottomTabsBezelBorder = 2,
		NSLeftTabsBezelBorder = 1,
		NSNoTabsBezelBorder = 4,
		NSNoTabsLineBorder = 5,
		NSNoTabsNoBorder = 6,
		NSRightTabsBezelBorder = 3,
		NSTopTabsBezelBorder = 0
	}
	public enum NSTestComparisonOperation {
		NSBeginsWithComparison = 5,
		NSContainsComparison = 7,
		NSEndsWithComparison = 6,
		NSEqualToComparison = 0,
		NSGreaterThanComparison = 4,
		NSGreaterThanOrEqualToComparison = 3,
		NSLessThanComparison = 2,
		NSLessThanOrEqualToComparison = 1
	}
	public enum NSTextAlignment {
		NSCenterTextAlignment = 2,
		NSJustifiedTextAlignment = 3,
		NSLeftTextAlignment = 0,
		NSNaturalTextAlignment = 4,
		NSRightTextAlignment = 1
	}
	public enum NSTextBlockDimension {
		NSTextBlockHeight = 4,
		NSTextBlockMaximumHeight = 6,
		NSTextBlockMaximumWidth = 2,
		NSTextBlockMinimumHeight = 5,
		NSTextBlockMinimumWidth = 1,
		NSTextBlockWidth = 0
	}
	public enum NSTextBlockValueType {
		NSTextBlockAbsoluteValueType = 0,
		NSTextBlockPercentageValueType = 1
	}
	public enum NSTextBlockVerticalAlignment {
		NSTextBlockBaselineAlignment = 3,
		NSTextBlockBottomAlignment = 2,
		NSTextBlockMiddleAlignment = 1,
		NSTextBlockTopAlignment = 0
	}
	public enum NSTextFieldBezelStyle {
		NSTextFieldRoundedBezel = 1,
		NSTextFieldSquareBezel = 0
	}
	public enum NSTextTableLayoutAlgorithm {
		NSTextTableAutomaticLayoutAlgorithm = 0,
		NSTextTableFixedLayoutAlgorithm = 1
	}
	public enum NSTextTabType {
		NSCenterTabStopType = 2,
		NSDecimalTabStopType = 3,
		NSLeftTabStopType = 0,
		NSRightTabStopType = 1
	}
	public enum NSTickMarkPosition {
		NSTickMarkAbove = 1,
		NSTickMarkBelow = 0,
		NSTickMarkLeft = 1,
		NSTickMarkRight = 0
	}
	public enum NSTIFFCompression {
		NSTIFFCompressionCCITTFAX3 = 3,
		NSTIFFCompressionCCITTFAX4 = 4,
		NSTIFFCompressionJPEG = 6,
		NSTIFFCompressionLZW = 5,
		NSTIFFCompressionNEXT = 32766,
		NSTIFFCompressionNone = 1,
		NSTIFFCompressionOldJPEG = 32865,
		NSTIFFCompressionPackBits = 32773
	}
	public enum NSTitlePosition {
		NSAboveBottom = 4,
		NSAboveTop = 1,
		NSAtBottom = 5,
		NSAtTop = 2,
		NSBelowBottom = 6,
		NSBelowTop = 3,
		NSNoTitle = 0
	}
	public enum NSTokenStyle {
		NSDefaultTokenStyle = 0,
		NSPlainTextTokenStyle = 1,
		NSRoundedTokenStyle = 2
	}
	public enum NSToolbarDisplayMode {
		NSToolbarDisplayModeDefault = 0,
		NSToolbarDisplayModeIconAndLabel = 1,
		NSToolbarDisplayModeIconOnly = 2,
		NSToolbarDisplayModeLabelOnly = 3
	}
	public enum NSToolbarSizeMode {
		NSToolbarSizeModeDefault = 0,
		NSToolbarSizeModeRegular = 1,
		NSToolbarSizeModeSmall = 2
	}
	public enum NSTrackingAreaOptions {
		NSTrackingAssumeInside = 256,
		NSTrackingEnabledDuringMouseDrag = 1024,
		NSTrackingInVisibleRect = 512
	}
	public enum NSTypesetterControlCharacterAction {
		NSTypesetterContainerBreakAction = 32,
		NSTypesetterHorizontalTabAction = 4,
		NSTypesetterLineBreakAction = 8,
		NSTypesetterParagraphBreakAction = 16,
		NSTypesetterWhitespaceAction = 2,
		NSTypesetterZeroAdvancementAction = 1
	}
	public enum NSURLCacheStoragePolicy {
		NSURLCacheStorageAllowed = 0,
		NSURLCacheStorageAllowedInMemoryOnly = 1,
		NSURLCacheStorageNotAllowed = 2
	}
	public enum NSURLCredentialPersistence {
		NSURLCredentialPersistenceForSession = 1,
		NSURLCredentialPersistenceNone = 0,
		NSURLCredentialPersistencePermanent = 2
	}
	public enum NSURLHandleStatus {
		NSURLHandleLoadFailed = 3,
		NSURLHandleLoadInProgress = 2,
		NSURLHandleLoadSucceeded = 1,
		NSURLHandleNotLoaded = 0
	}
	public enum NSURLRequestCachePolicy {
		NSURLRequestReloadIgnoringCacheData = 1,
		NSURLRequestReloadIgnoringLocalAndRemoteCacheData = 4,
		NSURLRequestReloadIgnoringLocalCacheData = 1,
		NSURLRequestReloadRevalidatingCacheData = 5,
		NSURLRequestReturnCacheDataDontLoad = 3,
		NSURLRequestReturnCacheDataElseLoad = 2,
		NSURLRequestUseProtocolCachePolicy = 0
	}
	public enum NSUsableScrollerParts {
		NSAllScrollerParts = 2,
		NSNoScrollerParts = 0,
		NSOnlyScrollerArrows = 1
	}
	public enum NSWhoseSubelementIdentifier {
		NSEverySubelement = 1,
		NSIndexSubelement = 0,
		NSMiddleSubelement = 2,
		NSNoSubelement = 4,
		NSRandomSubelement = 3
	}
	public enum NSWindingRule {
		NSEvenOddWindingRule = 1,
		NSNonZeroWindingRule = 0
	}
	public enum NSWindowBackingLocation {
		NSWindowBackingLocationDefault = 0,
		NSWindowBackingLocationMainMemory = 2,
		NSWindowBackingLocationVideoMemory = 1
	}
	public enum NSWindowButton {
		NSWindowCloseButton = 0,
		NSWindowDocumentIconButton = 4,
		NSWindowMiniaturizeButton = 1,
		NSWindowToolbarButton = 3,
		NSWindowZoomButton = 2
	}
	public enum NSWindowCollectionBehavior {
		NSWindowCollectionBehaviorCanJoinAllSpaces = 1,
		NSWindowCollectionBehaviorDefault = 0,
		NSWindowCollectionBehaviorMoveToActiveSpace = 2
	}
	public enum NSWindowSharingType {
		NSWindowSharingNone = 0,
		NSWindowSharingReadOnly = 1,
		NSWindowSharingReadWrite = 2
	}
	public enum NSWorkspaceIconCreationOptions {
		NSWorkspaceLaunchAllowingClassicStartup = 131072,
		NSWorkspaceLaunchAndHide = 1048576,
		NSWorkspaceLaunchAndHideOthers = 2097152,
		NSWorkspaceLaunchAndPrint = 2,
		NSWorkspaceLaunchAsync = 65536,
		NSWorkspaceLaunchDefault = 196608,
		NSWorkspaceLaunchInhibitingBackgroundOnly = 128,
		NSWorkspaceLaunchNewInstance = 524288,
		NSWorkspaceLaunchPreferringClassic = 262144,
		NSWorkspaceLaunchWithoutActivation = 512,
		NSWorkspaceLaunchWithoutAddingToRecents = 256
	}
	public enum NSXMLDocumentContentKind {
		NSXMLDocumentHTMLKind = 2,
		NSXMLDocumentTextKind = 3,
		NSXMLDocumentXHTMLKind = 1,
		NSXMLDocumentXMLKind = 0
	}
	public enum NSXMLDTDNodeKind {
		NSXMLAttributeCDATAKind = 6,
		NSXMLAttributeEntitiesKind = 11,
		NSXMLAttributeEntityKind = 10,
		NSXMLAttributeEnumerationKind = 14,
		NSXMLAttributeIDKind = 7,
		NSXMLAttributeIDRefKind = 8,
		NSXMLAttributeIDRefsKind = 9,
		NSXMLAttributeNMTokenKind = 12,
		NSXMLAttributeNMTokensKind = 13,
		NSXMLAttributeNotationKind = 15,
		NSXMLElementDeclarationAnyKind = 18,
		NSXMLElementDeclarationElementKind = 20,
		NSXMLElementDeclarationEmptyKind = 17,
		NSXMLElementDeclarationMixedKind = 19,
		NSXMLElementDeclarationUndefinedKind = 16,
		NSXMLEntityGeneralKind = 1,
		NSXMLEntityParameterKind = 4,
		NSXMLEntityParsedKind = 2,
		NSXMLEntityPredefined = 5,
		NSXMLEntityUnparsedKind = 3
	}
	public enum NSXMLNodeKind {
		NSXMLAttributeDeclarationKind = 10,
		NSXMLAttributeKind = 3,
		NSXMLCommentKind = 6,
		NSXMLDocumentKind = 1,
		NSXMLDTDKind = 8,
		NSXMLElementDeclarationKind = 11,
		NSXMLElementKind = 2,
		NSXMLEntityDeclarationKind = 9,
		NSXMLInvalidKind = 0,
		NSXMLNamespaceKind = 4,
		NSXMLNotationDeclarationKind = 12,
		NSXMLProcessingInstructionKind = 5,
		NSXMLTextKind = 7
	}
	public enum WebCacheModel {
		WebCacheModelDocumentBrowser = 1,
		WebCacheModelDocumentViewer = 0,
		WebCacheModelPrimaryWebBrowser = 2
	}
	public enum WebDragDestinationAction {
		WebDragDestinationActionAny = -1,
		WebDragDestinationActionDHTML = 1,
		WebDragDestinationActionEdit = 2,
		WebDragDestinationActionLoad = 4,
		WebDragDestinationActionNone = 0
	}
	public enum WebDragSourceAction {
		WebDragSourceActionAny = -1,
		WebDragSourceActionDHTML = 1,
		WebDragSourceActionImage = 2,
		WebDragSourceActionLink = 4,
		WebDragSourceActionNone = 0,
		WebDragSourceActionSelection = 8
	}
	public enum WebViewInsertAction {
		WebViewInsertActionDropped = 2,
		WebViewInsertActionPasted = 1,
		WebViewInsertActionTyped = 0
	}
}
