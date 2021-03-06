//    Copyright 2006, 2007, 2008 East Tech Incorporated
//
//    This file is part of FIX4NET.
//
//    FIX4NET is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    FIX4NET is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with FIX4NET.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Collections;
using System.Text;

using FIX = FIX4NET.FIX;

namespace FIX4NET.FIX.FIX_4_4
{
	/// <summary>
	/// Summary description for NewOrderCross.
	/// </summary>
	public class NewOrderCross : Message
	{
		public const int TAG_CrossID = 548;
		public const int TAG_CrossType = 549;
		public const int TAG_CrossPrioritization = 550;
		public const int TAG_NoSides = 552;
		public const int TAG_Side = 54;
		public const int TAG_ClOrdID = 11;
		public const int TAG_SecondaryClOrdID = 526;
		public const int TAG_ClOrdLinkID = 583;
		public const int TAG_NoPartyIDs = 453;
		public const int TAG_PartyID = 448;
		public const int TAG_PartyIDSource = 447;
		public const int TAG_PartyRole = 452;
		public const int TAG_NoPartySubIDs = 802;
		public const int TAG_PartySubID = 523;
		public const int TAG_PartySubIDType = 803;
		public const int TAG_TradeOriginationDate = 229;
		public const int TAG_TradeDate = 75;
		public const int TAG_Account = 1;
		public const int TAG_AcctIDSource = 660;
		public const int TAG_AccountType = 581;
		public const int TAG_DayBookingInst = 589;
		public const int TAG_BookingUnit = 590;
		public const int TAG_PreallocMethod = 591;
		public const int TAG_AllocID = 70;
		public const int TAG_NoAllocs = 78;
		public const int TAG_AllocAccount = 79;
		public const int TAG_AllocAcctIDSource = 661;
		public const int TAG_AllocSettlCurrency = 736;
		public const int TAG_IndividualAllocID = 467;
		public const int TAG_NoNestedPartyIDs = 539;
		public const int TAG_NestedPartyID = 524;
		public const int TAG_NestedPartyIDSource = 525;
		public const int TAG_NestedPartyRole = 538;
		public const int TAG_NoNestedPartySubIDs = 804;
		public const int TAG_NestedPartySubID = 545;
		public const int TAG_NestedPartySubIDType = 805;
		public const int TAG_AllocQty = 80;
		public const int TAG_QtyType = 854;
		public const int TAG_OrderQty = 38;
		public const int TAG_CashOrderQty = 152;
		public const int TAG_OrderPercent = 516;
		public const int TAG_RoundingDirection = 468;
		public const int TAG_RoundingModulus = 469;
		public const int TAG_Commission = 12;
		public const int TAG_CommType = 13;
		public const int TAG_CommCurrency = 479;
		public const int TAG_FundRenewWaiv = 497;
		public const int TAG_OrderCapacity = 528;
		public const int TAG_OrderRestrictions = 529;
		public const int TAG_CustOrderCapacity = 582;
		public const int TAG_ForexReq = 121;
		public const int TAG_SettlCurrency = 120;
		public const int TAG_BookingType = 775;
		public const int TAG_Text = 58;
		public const int TAG_EncodedTextLen = 354;
		public const int TAG_EncodedText = 355;
		public const int TAG_PositionEffect = 77;
		public const int TAG_CoveredOrUncovered = 203;
		public const int TAG_CashMargin = 544;
		public const int TAG_ClearingFeeIndicator = 635;
		public const int TAG_SolicitedFlag = 377;
		public const int TAG_SideComplianceID = 659;
		public const int TAG_Symbol = 55;
		public const int TAG_SymbolSfx = 65;
		public const int TAG_SecurityID = 48;
		public const int TAG_SecurityIDSource = 22;
		public const int TAG_NoSecurityAltID = 454;
		public const int TAG_SecurityAltID = 455;
		public const int TAG_SecurityAltIDSource = 456;
		public const int TAG_Product = 460;
		public const int TAG_CFICode = 461;
		public const int TAG_SecurityType = 167;
		public const int TAG_SecuritySubType = 762;
		public const int TAG_MaturityMonthYear = 200;
		public const int TAG_MaturityDate = 541;
		public const int TAG_CouponPaymentDate = 224;
		public const int TAG_IssueDate = 225;
		public const int TAG_RepoCollateralSecurityType = 239;
		public const int TAG_RepurchaseTerm = 226;
		public const int TAG_RepurchaseRate = 227;
		public const int TAG_Factor = 228;
		public const int TAG_CreditRating = 255;
		public const int TAG_InstrRegistry = 543;
		public const int TAG_CountryOfIssue = 470;
		public const int TAG_StateOrProvinceOfIssue = 471;
		public const int TAG_LocaleOfIssue = 472;
		public const int TAG_RedemptionDate = 240;
		public const int TAG_StrikePrice = 202;
		public const int TAG_StrikeCurrency = 947;
		public const int TAG_OptAttribute = 206;
		public const int TAG_ContractMultiplier = 231;
		public const int TAG_CouponRate = 223;
		public const int TAG_SecurityExchange = 207;
		public const int TAG_Issuer = 106;
		public const int TAG_EncodedIssuerLen = 348;
		public const int TAG_EncodedIssuer = 349;
		public const int TAG_SecurityDesc = 107;
		public const int TAG_EncodedSecurityDescLen = 350;
		public const int TAG_EncodedSecurityDesc = 351;
		public const int TAG_Pool = 691;
		public const int TAG_ContractSettlMonth = 667;
		public const int TAG_CPProgram = 875;
		public const int TAG_CPRegType = 876;
		public const int TAG_NoEvents = 864;
		public const int TAG_EventType = 865;
		public const int TAG_EventDate = 866;
		public const int TAG_EventPx = 867;
		public const int TAG_EventText = 868;
		public const int TAG_DatedDate = 873;
		public const int TAG_InterestAccrualDate = 874;
		public const int TAG_NoUnderlyings = 711;
		public const int TAG_UnderlyingSymbol = 311;
		public const int TAG_UnderlyingSymbolSfx = 312;
		public const int TAG_UnderlyingSecurityID = 309;
		public const int TAG_UnderlyingSecurityIDSource = 305;
		public const int TAG_NoUnderlyingSecurityAltID = 457;
		public const int TAG_UnderlyingSecurityAltID = 458;
		public const int TAG_UnderlyingSecurityAltIDSource = 459;
		public const int TAG_UnderlyingProduct = 462;
		public const int TAG_UnderlyingCFICode = 463;
		public const int TAG_UnderlyingSecurityType = 310;
		public const int TAG_UnderlyingSecuritySubType = 763;
		public const int TAG_UnderlyingMaturityMonthYear = 313;
		public const int TAG_UnderlyingMaturityDate = 542;
		public const int TAG_UnderlyingCouponPaymentDate = 241;
		public const int TAG_UnderlyingIssueDate = 242;
		public const int TAG_UnderlyingRepoCollateralSecurityType = 243;
		public const int TAG_UnderlyingRepurchaseTerm = 244;
		public const int TAG_UnderlyingRepurchaseRate = 245;
		public const int TAG_UnderlyingFactor = 246;
		public const int TAG_UnderlyingCreditRating = 256;
		public const int TAG_UnderlyingInstrRegistry = 595;
		public const int TAG_UnderlyingCountryOfIssue = 592;
		public const int TAG_UnderlyingStateOrProvinceOfIssue = 593;
		public const int TAG_UnderlyingLocaleOfIssue = 594;
		public const int TAG_UnderlyingRedemptionDate = 247;
		public const int TAG_UnderlyingStrikePrice = 316;
		public const int TAG_UnderlyingStrikeCurrency = 941;
		public const int TAG_UnderlyingOptAttribute = 317;
		public const int TAG_UnderlyingContractMultiplier = 436;
		public const int TAG_UnderlyingCouponRate = 435;
		public const int TAG_UnderlyingSecurityExchange = 308;
		public const int TAG_UnderlyingIssuer = 306;
		public const int TAG_EncodedUnderlyingIssuerLen = 362;
		public const int TAG_EncodedUnderlyingIssuer = 363;
		public const int TAG_UnderlyingSecurityDesc = 307;
		public const int TAG_EncodedUnderlyingSecurityDescLen = 364;
		public const int TAG_EncodedUnderlyingSecurityDesc = 365;
		public const int TAG_UnderlyingCPProgram = 877;
		public const int TAG_UnderlyingCPRegType = 878;
		public const int TAG_UnderlyingCurrency = 318;
		public const int TAG_UnderlyingQty = 879;
		public const int TAG_UnderlyingPx = 810;
		public const int TAG_UnderlyingDirtyPrice = 882;
		public const int TAG_UnderlyingEndPrice = 883;
		public const int TAG_UnderlyingStartValue = 884;
		public const int TAG_UnderlyingCurrentValue = 885;
		public const int TAG_UnderlyingEndValue = 886;
		public const int TAG_NoLegs = 555;
		public const int TAG_LegSymbol = 600;
		public const int TAG_LegSymbolSfx = 601;
		public const int TAG_LegSecurityID = 602;
		public const int TAG_LegSecurityIDSource = 603;
		public const int TAG_NoLegSecurityAltID = 604;
		public const int TAG_LegSecurityAltID = 605;
		public const int TAG_LegSecurityAltIDSource = 606;
		public const int TAG_LegProduct = 607;
		public const int TAG_LegCFICode = 608;
		public const int TAG_LegSecurityType = 609;
		public const int TAG_LegSecuritySubType = 764;
		public const int TAG_LegMaturityMonthYear = 610;
		public const int TAG_LegMaturityDate = 611;
		public const int TAG_LegCouponPaymentDate = 248;
		public const int TAG_LegIssueDate = 249;
		public const int TAG_LegRepoCollateralSecurityType = 250;
		public const int TAG_LegRepurchaseTerm = 251;
		public const int TAG_LegRepurchaseRate = 252;
		public const int TAG_LegFactor = 253;
		public const int TAG_LegCreditRating = 257;
		public const int TAG_LegInstrRegistry = 599;
		public const int TAG_LegCountryOfIssue = 596;
		public const int TAG_LegStateOrProvinceOfIssue = 597;
		public const int TAG_LegLocaleOfIssue = 598;
		public const int TAG_LegRedemptionDate = 254;
		public const int TAG_LegStrikePrice = 612;
		public const int TAG_LegStrikeCurrency = 942;
		public const int TAG_LegOptAttribute = 613;
		public const int TAG_LegContractMultiplier = 614;
		public const int TAG_LegCouponRate = 615;
		public const int TAG_LegSecurityExchange = 616;
		public const int TAG_LegIssuer = 617;
		public const int TAG_EncodedLegIssuerLen = 618;
		public const int TAG_EncodedLegIssuer = 619;
		public const int TAG_LegSecurityDesc = 620;
		public const int TAG_EncodedLegSecurityDescLen = 621;
		public const int TAG_EncodedLegSecurityDesc = 622;
		public const int TAG_LegRatioQty = 623;
		public const int TAG_LegSide = 624;
		public const int TAG_LegCurrency = 556;
		public const int TAG_LegPool = 740;
		public const int TAG_LegDatedDate = 739;
		public const int TAG_LegContractSettlMonth = 955;
		public const int TAG_LegInterestAccrualDate = 956;
		public const int TAG_SettlType = 63;
		public const int TAG_SettlDate = 64;
		public const int TAG_HandlInst = 21;
		public const int TAG_ExecInst = 18;
		public const int TAG_MinQty = 110;
		public const int TAG_MaxFloor = 111;
		public const int TAG_ExDestination = 100;
		public const int TAG_NoTradingSessions = 386;
		public const int TAG_TradingSessionID = 336;
		public const int TAG_TradingSessionSubID = 625;
		public const int TAG_ProcessCode = 81;
		public const int TAG_PrevClosePx = 140;
		public const int TAG_LocateReqd = 114;
		public const int TAG_TransactTime = 60;
		public const int TAG_NoStipulations = 232;
		public const int TAG_StipulationType = 233;
		public const int TAG_StipulationValue = 234;
		public const int TAG_OrdType = 40;
		public const int TAG_PriceType = 423;
		public const int TAG_Price = 44;
		public const int TAG_StopPx = 99;
		public const int TAG_Spread = 218;
		public const int TAG_BenchmarkCurveCurrency = 220;
		public const int TAG_BenchmarkCurveName = 221;
		public const int TAG_BenchmarkCurvePoint = 222;
		public const int TAG_BenchmarkPrice = 662;
		public const int TAG_BenchmarkPriceType = 663;
		public const int TAG_BenchmarkSecurityID = 699;
		public const int TAG_BenchmarkSecurityIDSource = 761;
		public const int TAG_YieldType = 235;
		public const int TAG_Yield = 236;
		public const int TAG_YieldCalcDate = 701;
		public const int TAG_YieldRedemptionDate = 696;
		public const int TAG_YieldRedemptionPrice = 697;
		public const int TAG_YieldRedemptionPriceType = 698;
		public const int TAG_Currency = 15;
		public const int TAG_ComplianceID = 376;
		public const int TAG_IOIid = 23;
		public const int TAG_QuoteID = 117;
		public const int TAG_TimeInForce = 59;
		public const int TAG_EffectiveTime = 168;
		public const int TAG_ExpireDate = 432;
		public const int TAG_ExpireTime = 126;
		public const int TAG_GTBookingInst = 427;
		public const int TAG_MaxShow = 210;
		public const int TAG_PegOffsetValue = 211;
		public const int TAG_PegMoveType = 835;
		public const int TAG_PegOffsetType = 836;
		public const int TAG_PegLimitType = 837;
		public const int TAG_PegRoundDirection = 838;
		public const int TAG_PegScope = 840;
		public const int TAG_DiscretionInst = 388;
		public const int TAG_DiscretionOffsetValue = 389;
		public const int TAG_DiscretionMoveType = 841;
		public const int TAG_DiscretionOffsetType = 842;
		public const int TAG_DiscretionLimitType = 843;
		public const int TAG_DiscretionRoundDirection = 844;
		public const int TAG_DiscretionScope = 846;
		public const int TAG_TargetStrategy = 847;
		public const int TAG_TargetStrategyParameters = 848;
		public const int TAG_ParticipationRate = 849;
		public const int TAG_CancellationRights = 480;
		public const int TAG_MoneyLaunderingStatus = 481;
		public const int TAG_RegistID = 513;
		public const int TAG_Designation = 494;

		private string _sCrossID;
		private int _iCrossType;
		private int _iCrossPrioritization;
		private int _iNoSides;
		private NewOrderCrossSideList _listSide = new NewOrderCrossSideList();
		private string _sSymbol;
		private string _sSymbolSfx;
		private string _sSecurityID;
		private string _sSecurityIDSource;
		private int _iNoSecurityAltID;
		private NewOrderCrossSecurityAltIDList _listSecurityAltID = new NewOrderCrossSecurityAltIDList();
		private int _iProduct;
		private string _sCFICode;
		private string _sSecurityType;
		private string _sSecuritySubType;
		private DateTime _dtMaturityMonthYear;
		private DateTime _dtMaturityDate;
		private DateTime _dtCouponPaymentDate;
		private DateTime _dtIssueDate;
		private int _iRepoCollateralSecurityType;
		private int _iRepurchaseTerm;
		private double _dRepurchaseRate;
		private double _dFactor;
		private string _sCreditRating;
		private string _sInstrRegistry;
		private string _sCountryOfIssue;
		private string _sStateOrProvinceOfIssue;
		private string _sLocaleOfIssue;
		private DateTime _dtRedemptionDate;
		private double _dStrikePrice;
		private string _sStrikeCurrency;
		private char _cOptAttribute;
		private double _dContractMultiplier;
		private double _dCouponRate;
		private string _sSecurityExchange;
		private string _sIssuer;
		private int _iEncodedIssuerLen;
		private string _sEncodedIssuer;
		private string _sSecurityDesc;
		private int _iEncodedSecurityDescLen;
		private string _sEncodedSecurityDesc;
		private string _sPool;
		private DateTime _dtContractSettlMonth;
		private int _iCPProgram;
		private string _sCPRegType;
		private int _iNoEvents;
		private NewOrderCrossEventList _listEvent = new NewOrderCrossEventList();
		private DateTime _dtDatedDate;
		private DateTime _dtInterestAccrualDate;
		private int _iNoUnderlyings;
		private NewOrderCrossUnderlyingList _listUnderlying = new NewOrderCrossUnderlyingList();
		private int _iNoLegs;
		private NewOrderCrossLegList _listLeg = new NewOrderCrossLegList();
		private char _cSettlType;
		private DateTime _dtSettlDate;
		private char _cHandlInst;
		private string _sExecInst;
		private int _iMinQty;
		private int _iMaxFloor;
		private string _sExDestination;
		private int _iNoTradingSessions;
		private NewOrderCrossTradingSessionList _listTradingSession = new NewOrderCrossTradingSessionList();
		private char _cProcessCode;
		private double _dPrevClosePx;
		private bool _bLocateReqd;
		private DateTime _dtTransactTime;
		private int _iNoStipulations;
		private NewOrderCrossStipulationList _listStipulation = new NewOrderCrossStipulationList();
		private char _cOrdType;
		private int _iPriceType;
		private double _dPrice;
		private double _dStopPx;
		private double _dSpread;
		private string _sBenchmarkCurveCurrency;
		private string _sBenchmarkCurveName;
		private string _sBenchmarkCurvePoint;
		private double _dBenchmarkPrice;
		private int _iBenchmarkPriceType;
		private string _sBenchmarkSecurityID;
		private string _sBenchmarkSecurityIDSource;
		private string _sYieldType;
		private double _dYield;
		private DateTime _dtYieldCalcDate;
		private DateTime _dtYieldRedemptionDate;
		private double _dYieldRedemptionPrice;
		private int _iYieldRedemptionPriceType;
		private string _sCurrency;
		private string _sComplianceID;
		private string _sIOIid;
		private string _sQuoteID;
		private char _cTimeInForce;
		private DateTime _dtEffectiveTime;
		private DateTime _dtExpireDate;
		private DateTime _dtExpireTime;
		private int _iGTBookingInst;
		private int _iMaxShow;
		private double _dPegOffsetValue;
		private int _iPegMoveType;
		private int _iPegOffsetType;
		private int _iPegLimitType;
		private int _iPegRoundDirection;
		private int _iPegScope;
		private char _cDiscretionInst;
		private double _dDiscretionOffsetValue;
		private int _iDiscretionMoveType;
		private int _iDiscretionOffsetType;
		private int _iDiscretionLimitType;
		private int _iDiscretionRoundDirection;
		private int _iDiscretionScope;
		private int _iTargetStrategy;
		private string _sTargetStrategyParameters;
		private double _dParticipationRate;
		private char _cCancellationRights;
		private char _cMoneyLaunderingStatus;
		private string _sRegistID;
		private string _sDesignation;

		public NewOrderCross() : base()
		{
			_sMsgType = Values.MsgType.NewOrderCross;
		}

		public string CrossID
		{
			get { return _sCrossID; }
			set { _sCrossID = value; }
		}
		public int CrossType
		{
			get { return _iCrossType; }
			set { _iCrossType = value; }
		}
		public int CrossPrioritization
		{
			get { return _iCrossPrioritization; }
			set { _iCrossPrioritization = value; }
		}
		public int NoSides
		{
			get { return _iNoSides; }
			set { _iNoSides = value; }
		}
		public NewOrderCrossSideList Side 
		{
			get { return _listSide; }
		}
		public string Symbol
		{
			get { return _sSymbol; }
			set { _sSymbol = value; }
		}
		public string SymbolSfx
		{
			get { return _sSymbolSfx; }
			set { _sSymbolSfx = value; }
		}
		public string SecurityID
		{
			get { return _sSecurityID; }
			set { _sSecurityID = value; }
		}
		public string SecurityIDSource
		{
			get { return _sSecurityIDSource; }
			set { _sSecurityIDSource = value; }
		}
		public int NoSecurityAltID
		{
			get { return _iNoSecurityAltID; }
			set { _iNoSecurityAltID = value; }
		}
		public NewOrderCrossSecurityAltIDList SecurityAltID 
		{
			get { return _listSecurityAltID; }
		}
		public int Product
		{
			get { return _iProduct; }
			set { _iProduct = value; }
		}
		public string CFICode
		{
			get { return _sCFICode; }
			set { _sCFICode = value; }
		}
		public string SecurityType
		{
			get { return _sSecurityType; }
			set { _sSecurityType = value; }
		}
		public string SecuritySubType
		{
			get { return _sSecuritySubType; }
			set { _sSecuritySubType = value; }
		}
		public DateTime MaturityMonthYear
		{
			get { return _dtMaturityMonthYear; }
			set { _dtMaturityMonthYear = value; }
		}
		public DateTime MaturityDate
		{
			get { return _dtMaturityDate; }
			set { _dtMaturityDate = value; }
		}
		public DateTime CouponPaymentDate
		{
			get { return _dtCouponPaymentDate; }
			set { _dtCouponPaymentDate = value; }
		}
		public DateTime IssueDate
		{
			get { return _dtIssueDate; }
			set { _dtIssueDate = value; }
		}
		public int RepoCollateralSecurityType
		{
			get { return _iRepoCollateralSecurityType; }
			set { _iRepoCollateralSecurityType = value; }
		}
		public int RepurchaseTerm
		{
			get { return _iRepurchaseTerm; }
			set { _iRepurchaseTerm = value; }
		}
		public double RepurchaseRate
		{
			get { return _dRepurchaseRate; }
			set { _dRepurchaseRate = value; }
		}
		public double Factor
		{
			get { return _dFactor; }
			set { _dFactor = value; }
		}
		public string CreditRating
		{
			get { return _sCreditRating; }
			set { _sCreditRating = value; }
		}
		public string InstrRegistry
		{
			get { return _sInstrRegistry; }
			set { _sInstrRegistry = value; }
		}
		public string CountryOfIssue
		{
			get { return _sCountryOfIssue; }
			set { _sCountryOfIssue = value; }
		}
		public string StateOrProvinceOfIssue
		{
			get { return _sStateOrProvinceOfIssue; }
			set { _sStateOrProvinceOfIssue = value; }
		}
		public string LocaleOfIssue
		{
			get { return _sLocaleOfIssue; }
			set { _sLocaleOfIssue = value; }
		}
		public DateTime RedemptionDate
		{
			get { return _dtRedemptionDate; }
			set { _dtRedemptionDate = value; }
		}
		public double StrikePrice
		{
			get { return _dStrikePrice; }
			set { _dStrikePrice = value; }
		}
		public string StrikeCurrency
		{
			get { return _sStrikeCurrency; }
			set { _sStrikeCurrency = value; }
		}
		public char OptAttribute
		{
			get { return _cOptAttribute; }
			set { _cOptAttribute = value; }
		}
		public double ContractMultiplier
		{
			get { return _dContractMultiplier; }
			set { _dContractMultiplier = value; }
		}
		public double CouponRate
		{
			get { return _dCouponRate; }
			set { _dCouponRate = value; }
		}
		public string SecurityExchange
		{
			get { return _sSecurityExchange; }
			set { _sSecurityExchange = value; }
		}
		public string Issuer
		{
			get { return _sIssuer; }
			set { _sIssuer = value; }
		}
		public int EncodedIssuerLen
		{
			get { return _iEncodedIssuerLen; }
			set { _iEncodedIssuerLen = value; }
		}
		public string EncodedIssuer
		{
			get { return _sEncodedIssuer; }
			set { _sEncodedIssuer = value; }
		}
		public string SecurityDesc
		{
			get { return _sSecurityDesc; }
			set { _sSecurityDesc = value; }
		}
		public int EncodedSecurityDescLen
		{
			get { return _iEncodedSecurityDescLen; }
			set { _iEncodedSecurityDescLen = value; }
		}
		public string EncodedSecurityDesc
		{
			get { return _sEncodedSecurityDesc; }
			set { _sEncodedSecurityDesc = value; }
		}
		public string Pool
		{
			get { return _sPool; }
			set { _sPool = value; }
		}
		public DateTime ContractSettlMonth
		{
			get { return _dtContractSettlMonth; }
			set { _dtContractSettlMonth = value; }
		}
		public int CPProgram
		{
			get { return _iCPProgram; }
			set { _iCPProgram = value; }
		}
		public string CPRegType
		{
			get { return _sCPRegType; }
			set { _sCPRegType = value; }
		}
		public int NoEvents
		{
			get { return _iNoEvents; }
			set { _iNoEvents = value; }
		}
		public NewOrderCrossEventList Event 
		{
			get { return _listEvent; }
		}
		public DateTime DatedDate
		{
			get { return _dtDatedDate; }
			set { _dtDatedDate = value; }
		}
		public DateTime InterestAccrualDate
		{
			get { return _dtInterestAccrualDate; }
			set { _dtInterestAccrualDate = value; }
		}
		public int NoUnderlyings
		{
			get { return _iNoUnderlyings; }
			set { _iNoUnderlyings = value; }
		}
		public NewOrderCrossUnderlyingList Underlying 
		{
			get { return _listUnderlying; }
		}
		public int NoLegs
		{
			get { return _iNoLegs; }
			set { _iNoLegs = value; }
		}
		public NewOrderCrossLegList Leg 
		{
			get { return _listLeg; }
		}
		public char SettlType
		{
			get { return _cSettlType; }
			set { _cSettlType = value; }
		}
		public DateTime SettlDate
		{
			get { return _dtSettlDate; }
			set { _dtSettlDate = value; }
		}
		public char HandlInst
		{
			get { return _cHandlInst; }
			set { _cHandlInst = value; }
		}
		public string ExecInst
		{
			get { return _sExecInst; }
			set { _sExecInst = value; }
		}
		public int MinQty
		{
			get { return _iMinQty; }
			set { _iMinQty = value; }
		}
		public int MaxFloor
		{
			get { return _iMaxFloor; }
			set { _iMaxFloor = value; }
		}
		public string ExDestination
		{
			get { return _sExDestination; }
			set { _sExDestination = value; }
		}
		public int NoTradingSessions
		{
			get { return _iNoTradingSessions; }
			set { _iNoTradingSessions = value; }
		}
		public NewOrderCrossTradingSessionList TradingSession 
		{
			get { return _listTradingSession; }
		}
		public char ProcessCode
		{
			get { return _cProcessCode; }
			set { _cProcessCode = value; }
		}
		public double PrevClosePx
		{
			get { return _dPrevClosePx; }
			set { _dPrevClosePx = value; }
		}
		public bool LocateReqd
		{
			get { return _bLocateReqd; }
			set { _bLocateReqd = value; }
		}
		public DateTime TransactTime
		{
			get { return _dtTransactTime; }
			set { _dtTransactTime = value; }
		}
		public int NoStipulations
		{
			get { return _iNoStipulations; }
			set { _iNoStipulations = value; }
		}
		public NewOrderCrossStipulationList Stipulation 
		{
			get { return _listStipulation; }
		}
		public char OrdType
		{
			get { return _cOrdType; }
			set { _cOrdType = value; }
		}
		public int PriceType
		{
			get { return _iPriceType; }
			set { _iPriceType = value; }
		}
		public double Price
		{
			get { return _dPrice; }
			set { _dPrice = value; }
		}
		public double StopPx
		{
			get { return _dStopPx; }
			set { _dStopPx = value; }
		}
		public double Spread
		{
			get { return _dSpread; }
			set { _dSpread = value; }
		}
		public string BenchmarkCurveCurrency
		{
			get { return _sBenchmarkCurveCurrency; }
			set { _sBenchmarkCurveCurrency = value; }
		}
		public string BenchmarkCurveName
		{
			get { return _sBenchmarkCurveName; }
			set { _sBenchmarkCurveName = value; }
		}
		public string BenchmarkCurvePoint
		{
			get { return _sBenchmarkCurvePoint; }
			set { _sBenchmarkCurvePoint = value; }
		}
		public double BenchmarkPrice
		{
			get { return _dBenchmarkPrice; }
			set { _dBenchmarkPrice = value; }
		}
		public int BenchmarkPriceType
		{
			get { return _iBenchmarkPriceType; }
			set { _iBenchmarkPriceType = value; }
		}
		public string BenchmarkSecurityID
		{
			get { return _sBenchmarkSecurityID; }
			set { _sBenchmarkSecurityID = value; }
		}
		public string BenchmarkSecurityIDSource
		{
			get { return _sBenchmarkSecurityIDSource; }
			set { _sBenchmarkSecurityIDSource = value; }
		}
		public string YieldType
		{
			get { return _sYieldType; }
			set { _sYieldType = value; }
		}
		public double Yield
		{
			get { return _dYield; }
			set { _dYield = value; }
		}
		public DateTime YieldCalcDate
		{
			get { return _dtYieldCalcDate; }
			set { _dtYieldCalcDate = value; }
		}
		public DateTime YieldRedemptionDate
		{
			get { return _dtYieldRedemptionDate; }
			set { _dtYieldRedemptionDate = value; }
		}
		public double YieldRedemptionPrice
		{
			get { return _dYieldRedemptionPrice; }
			set { _dYieldRedemptionPrice = value; }
		}
		public int YieldRedemptionPriceType
		{
			get { return _iYieldRedemptionPriceType; }
			set { _iYieldRedemptionPriceType = value; }
		}
		public string Currency
		{
			get { return _sCurrency; }
			set { _sCurrency = value; }
		}
		public string ComplianceID
		{
			get { return _sComplianceID; }
			set { _sComplianceID = value; }
		}
		public string IOIid
		{
			get { return _sIOIid; }
			set { _sIOIid = value; }
		}
		public string QuoteID
		{
			get { return _sQuoteID; }
			set { _sQuoteID = value; }
		}
		public char TimeInForce
		{
			get { return _cTimeInForce; }
			set { _cTimeInForce = value; }
		}
		public DateTime EffectiveTime
		{
			get { return _dtEffectiveTime; }
			set { _dtEffectiveTime = value; }
		}
		public DateTime ExpireDate
		{
			get { return _dtExpireDate; }
			set { _dtExpireDate = value; }
		}
		public DateTime ExpireTime
		{
			get { return _dtExpireTime; }
			set { _dtExpireTime = value; }
		}
		public int GTBookingInst
		{
			get { return _iGTBookingInst; }
			set { _iGTBookingInst = value; }
		}
		public int MaxShow
		{
			get { return _iMaxShow; }
			set { _iMaxShow = value; }
		}
		public double PegOffsetValue
		{
			get { return _dPegOffsetValue; }
			set { _dPegOffsetValue = value; }
		}
		public int PegMoveType
		{
			get { return _iPegMoveType; }
			set { _iPegMoveType = value; }
		}
		public int PegOffsetType
		{
			get { return _iPegOffsetType; }
			set { _iPegOffsetType = value; }
		}
		public int PegLimitType
		{
			get { return _iPegLimitType; }
			set { _iPegLimitType = value; }
		}
		public int PegRoundDirection
		{
			get { return _iPegRoundDirection; }
			set { _iPegRoundDirection = value; }
		}
		public int PegScope
		{
			get { return _iPegScope; }
			set { _iPegScope = value; }
		}
		public char DiscretionInst
		{
			get { return _cDiscretionInst; }
			set { _cDiscretionInst = value; }
		}
		public double DiscretionOffsetValue
		{
			get { return _dDiscretionOffsetValue; }
			set { _dDiscretionOffsetValue = value; }
		}
		public int DiscretionMoveType
		{
			get { return _iDiscretionMoveType; }
			set { _iDiscretionMoveType = value; }
		}
		public int DiscretionOffsetType
		{
			get { return _iDiscretionOffsetType; }
			set { _iDiscretionOffsetType = value; }
		}
		public int DiscretionLimitType
		{
			get { return _iDiscretionLimitType; }
			set { _iDiscretionLimitType = value; }
		}
		public int DiscretionRoundDirection
		{
			get { return _iDiscretionRoundDirection; }
			set { _iDiscretionRoundDirection = value; }
		}
		public int DiscretionScope
		{
			get { return _iDiscretionScope; }
			set { _iDiscretionScope = value; }
		}
		public int TargetStrategy
		{
			get { return _iTargetStrategy; }
			set { _iTargetStrategy = value; }
		}
		public string TargetStrategyParameters
		{
			get { return _sTargetStrategyParameters; }
			set { _sTargetStrategyParameters = value; }
		}
		public double ParticipationRate
		{
			get { return _dParticipationRate; }
			set { _dParticipationRate = value; }
		}
		public char CancellationRights
		{
			get { return _cCancellationRights; }
			set { _cCancellationRights = value; }
		}
		public char MoneyLaunderingStatus
		{
			get { return _cMoneyLaunderingStatus; }
			set { _cMoneyLaunderingStatus = value; }
		}
		public string RegistID
		{
			get { return _sRegistID; }
			set { _sRegistID = value; }
		}
		public string Designation
		{
			get { return _sDesignation; }
			set { _sDesignation = value; }
		}

		public override object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case TAG_CrossID:
						return _sCrossID;
					case TAG_CrossType:
						return _iCrossType;
					case TAG_CrossPrioritization:
						return _iCrossPrioritization;
					case TAG_NoSides:
						return _iNoSides;
					case TAG_Symbol:
						return _sSymbol;
					case TAG_SymbolSfx:
						return _sSymbolSfx;
					case TAG_SecurityID:
						return _sSecurityID;
					case TAG_SecurityIDSource:
						return _sSecurityIDSource;
					case TAG_NoSecurityAltID:
						return _iNoSecurityAltID;
					case TAG_Product:
						return _iProduct;
					case TAG_CFICode:
						return _sCFICode;
					case TAG_SecurityType:
						return _sSecurityType;
					case TAG_SecuritySubType:
						return _sSecuritySubType;
					case TAG_MaturityMonthYear:
						return _dtMaturityMonthYear;
					case TAG_MaturityDate:
						return _dtMaturityDate;
					case TAG_CouponPaymentDate:
						return _dtCouponPaymentDate;
					case TAG_IssueDate:
						return _dtIssueDate;
					case TAG_RepoCollateralSecurityType:
						return _iRepoCollateralSecurityType;
					case TAG_RepurchaseTerm:
						return _iRepurchaseTerm;
					case TAG_RepurchaseRate:
						return _dRepurchaseRate;
					case TAG_Factor:
						return _dFactor;
					case TAG_CreditRating:
						return _sCreditRating;
					case TAG_InstrRegistry:
						return _sInstrRegistry;
					case TAG_CountryOfIssue:
						return _sCountryOfIssue;
					case TAG_StateOrProvinceOfIssue:
						return _sStateOrProvinceOfIssue;
					case TAG_LocaleOfIssue:
						return _sLocaleOfIssue;
					case TAG_RedemptionDate:
						return _dtRedemptionDate;
					case TAG_StrikePrice:
						return _dStrikePrice;
					case TAG_StrikeCurrency:
						return _sStrikeCurrency;
					case TAG_OptAttribute:
						return _cOptAttribute;
					case TAG_ContractMultiplier:
						return _dContractMultiplier;
					case TAG_CouponRate:
						return _dCouponRate;
					case TAG_SecurityExchange:
						return _sSecurityExchange;
					case TAG_Issuer:
						return _sIssuer;
					case TAG_EncodedIssuerLen:
						return _iEncodedIssuerLen;
					case TAG_EncodedIssuer:
						return _sEncodedIssuer;
					case TAG_SecurityDesc:
						return _sSecurityDesc;
					case TAG_EncodedSecurityDescLen:
						return _iEncodedSecurityDescLen;
					case TAG_EncodedSecurityDesc:
						return _sEncodedSecurityDesc;
					case TAG_Pool:
						return _sPool;
					case TAG_ContractSettlMonth:
						return _dtContractSettlMonth;
					case TAG_CPProgram:
						return _iCPProgram;
					case TAG_CPRegType:
						return _sCPRegType;
					case TAG_NoEvents:
						return _iNoEvents;
					case TAG_DatedDate:
						return _dtDatedDate;
					case TAG_InterestAccrualDate:
						return _dtInterestAccrualDate;
					case TAG_NoUnderlyings:
						return _iNoUnderlyings;
					case TAG_NoLegs:
						return _iNoLegs;
					case TAG_SettlType:
						return _cSettlType;
					case TAG_SettlDate:
						return _dtSettlDate;
					case TAG_HandlInst:
						return _cHandlInst;
					case TAG_ExecInst:
						return _sExecInst;
					case TAG_MinQty:
						return _iMinQty;
					case TAG_MaxFloor:
						return _iMaxFloor;
					case TAG_ExDestination:
						return _sExDestination;
					case TAG_NoTradingSessions:
						return _iNoTradingSessions;
					case TAG_ProcessCode:
						return _cProcessCode;
					case TAG_PrevClosePx:
						return _dPrevClosePx;
					case TAG_LocateReqd:
						return _bLocateReqd;
					case TAG_TransactTime:
						return _dtTransactTime;
					case TAG_NoStipulations:
						return _iNoStipulations;
					case TAG_OrdType:
						return _cOrdType;
					case TAG_PriceType:
						return _iPriceType;
					case TAG_Price:
						return _dPrice;
					case TAG_StopPx:
						return _dStopPx;
					case TAG_Spread:
						return _dSpread;
					case TAG_BenchmarkCurveCurrency:
						return _sBenchmarkCurveCurrency;
					case TAG_BenchmarkCurveName:
						return _sBenchmarkCurveName;
					case TAG_BenchmarkCurvePoint:
						return _sBenchmarkCurvePoint;
					case TAG_BenchmarkPrice:
						return _dBenchmarkPrice;
					case TAG_BenchmarkPriceType:
						return _iBenchmarkPriceType;
					case TAG_BenchmarkSecurityID:
						return _sBenchmarkSecurityID;
					case TAG_BenchmarkSecurityIDSource:
						return _sBenchmarkSecurityIDSource;
					case TAG_YieldType:
						return _sYieldType;
					case TAG_Yield:
						return _dYield;
					case TAG_YieldCalcDate:
						return _dtYieldCalcDate;
					case TAG_YieldRedemptionDate:
						return _dtYieldRedemptionDate;
					case TAG_YieldRedemptionPrice:
						return _dYieldRedemptionPrice;
					case TAG_YieldRedemptionPriceType:
						return _iYieldRedemptionPriceType;
					case TAG_Currency:
						return _sCurrency;
					case TAG_ComplianceID:
						return _sComplianceID;
					case TAG_IOIid:
						return _sIOIid;
					case TAG_QuoteID:
						return _sQuoteID;
					case TAG_TimeInForce:
						return _cTimeInForce;
					case TAG_EffectiveTime:
						return _dtEffectiveTime;
					case TAG_ExpireDate:
						return _dtExpireDate;
					case TAG_ExpireTime:
						return _dtExpireTime;
					case TAG_GTBookingInst:
						return _iGTBookingInst;
					case TAG_MaxShow:
						return _iMaxShow;
					case TAG_PegOffsetValue:
						return _dPegOffsetValue;
					case TAG_PegMoveType:
						return _iPegMoveType;
					case TAG_PegOffsetType:
						return _iPegOffsetType;
					case TAG_PegLimitType:
						return _iPegLimitType;
					case TAG_PegRoundDirection:
						return _iPegRoundDirection;
					case TAG_PegScope:
						return _iPegScope;
					case TAG_DiscretionInst:
						return _cDiscretionInst;
					case TAG_DiscretionOffsetValue:
						return _dDiscretionOffsetValue;
					case TAG_DiscretionMoveType:
						return _iDiscretionMoveType;
					case TAG_DiscretionOffsetType:
						return _iDiscretionOffsetType;
					case TAG_DiscretionLimitType:
						return _iDiscretionLimitType;
					case TAG_DiscretionRoundDirection:
						return _iDiscretionRoundDirection;
					case TAG_DiscretionScope:
						return _iDiscretionScope;
					case TAG_TargetStrategy:
						return _iTargetStrategy;
					case TAG_TargetStrategyParameters:
						return _sTargetStrategyParameters;
					case TAG_ParticipationRate:
						return _dParticipationRate;
					case TAG_CancellationRights:
						return _cCancellationRights;
					case TAG_MoneyLaunderingStatus:
						return _cMoneyLaunderingStatus;
					case TAG_RegistID:
						return _sRegistID;
					case TAG_Designation:
						return _sDesignation;
					default:
						return base[iTag];
				}
			}
			set
			{
				switch (iTag)
				{
					case TAG_CrossID:
						_sCrossID = (string)value;
						break;
					case TAG_CrossType:
						_iCrossType = (int)value;
						break;
					case TAG_CrossPrioritization:
						_iCrossPrioritization = (int)value;
						break;
					case TAG_NoSides:
						_iNoSides = (int)value;
						break;
					case TAG_Symbol:
						_sSymbol = (string)value;
						break;
					case TAG_SymbolSfx:
						_sSymbolSfx = (string)value;
						break;
					case TAG_SecurityID:
						_sSecurityID = (string)value;
						break;
					case TAG_SecurityIDSource:
						_sSecurityIDSource = (string)value;
						break;
					case TAG_NoSecurityAltID:
						_iNoSecurityAltID = (int)value;
						break;
					case TAG_Product:
						_iProduct = (int)value;
						break;
					case TAG_CFICode:
						_sCFICode = (string)value;
						break;
					case TAG_SecurityType:
						_sSecurityType = (string)value;
						break;
					case TAG_SecuritySubType:
						_sSecuritySubType = (string)value;
						break;
					case TAG_MaturityMonthYear:
						_dtMaturityMonthYear = (DateTime)value;
						break;
					case TAG_MaturityDate:
						_dtMaturityDate = (DateTime)value;
						break;
					case TAG_CouponPaymentDate:
						_dtCouponPaymentDate = (DateTime)value;
						break;
					case TAG_IssueDate:
						_dtIssueDate = (DateTime)value;
						break;
					case TAG_RepoCollateralSecurityType:
						_iRepoCollateralSecurityType = (int)value;
						break;
					case TAG_RepurchaseTerm:
						_iRepurchaseTerm = (int)value;
						break;
					case TAG_RepurchaseRate:
						_dRepurchaseRate = (double)value;
						break;
					case TAG_Factor:
						_dFactor = (double)value;
						break;
					case TAG_CreditRating:
						_sCreditRating = (string)value;
						break;
					case TAG_InstrRegistry:
						_sInstrRegistry = (string)value;
						break;
					case TAG_CountryOfIssue:
						_sCountryOfIssue = (string)value;
						break;
					case TAG_StateOrProvinceOfIssue:
						_sStateOrProvinceOfIssue = (string)value;
						break;
					case TAG_LocaleOfIssue:
						_sLocaleOfIssue = (string)value;
						break;
					case TAG_RedemptionDate:
						_dtRedemptionDate = (DateTime)value;
						break;
					case TAG_StrikePrice:
						_dStrikePrice = (double)value;
						break;
					case TAG_StrikeCurrency:
						_sStrikeCurrency = (string)value;
						break;
					case TAG_OptAttribute:
						_cOptAttribute = (char)value;
						break;
					case TAG_ContractMultiplier:
						_dContractMultiplier = (double)value;
						break;
					case TAG_CouponRate:
						_dCouponRate = (double)value;
						break;
					case TAG_SecurityExchange:
						_sSecurityExchange = (string)value;
						break;
					case TAG_Issuer:
						_sIssuer = (string)value;
						break;
					case TAG_EncodedIssuerLen:
						_iEncodedIssuerLen = (int)value;
						break;
					case TAG_EncodedIssuer:
						_sEncodedIssuer = (string)value;
						break;
					case TAG_SecurityDesc:
						_sSecurityDesc = (string)value;
						break;
					case TAG_EncodedSecurityDescLen:
						_iEncodedSecurityDescLen = (int)value;
						break;
					case TAG_EncodedSecurityDesc:
						_sEncodedSecurityDesc = (string)value;
						break;
					case TAG_Pool:
						_sPool = (string)value;
						break;
					case TAG_ContractSettlMonth:
						_dtContractSettlMonth = (DateTime)value;
						break;
					case TAG_CPProgram:
						_iCPProgram = (int)value;
						break;
					case TAG_CPRegType:
						_sCPRegType = (string)value;
						break;
					case TAG_NoEvents:
						_iNoEvents = (int)value;
						break;
					case TAG_DatedDate:
						_dtDatedDate = (DateTime)value;
						break;
					case TAG_InterestAccrualDate:
						_dtInterestAccrualDate = (DateTime)value;
						break;
					case TAG_NoUnderlyings:
						_iNoUnderlyings = (int)value;
						break;
					case TAG_NoLegs:
						_iNoLegs = (int)value;
						break;
					case TAG_SettlType:
						_cSettlType = (char)value;
						break;
					case TAG_SettlDate:
						_dtSettlDate = (DateTime)value;
						break;
					case TAG_HandlInst:
						_cHandlInst = (char)value;
						break;
					case TAG_ExecInst:
						_sExecInst = (string)value;
						break;
					case TAG_MinQty:
						_iMinQty = (int)value;
						break;
					case TAG_MaxFloor:
						_iMaxFloor = (int)value;
						break;
					case TAG_ExDestination:
						_sExDestination = (string)value;
						break;
					case TAG_NoTradingSessions:
						_iNoTradingSessions = (int)value;
						break;
					case TAG_ProcessCode:
						_cProcessCode = (char)value;
						break;
					case TAG_PrevClosePx:
						_dPrevClosePx = (double)value;
						break;
					case TAG_LocateReqd:
						_bLocateReqd = (bool)value;
						break;
					case TAG_TransactTime:
						_dtTransactTime = (DateTime)value;
						break;
					case TAG_NoStipulations:
						_iNoStipulations = (int)value;
						break;
					case TAG_OrdType:
						_cOrdType = (char)value;
						break;
					case TAG_PriceType:
						_iPriceType = (int)value;
						break;
					case TAG_Price:
						_dPrice = (double)value;
						break;
					case TAG_StopPx:
						_dStopPx = (double)value;
						break;
					case TAG_Spread:
						_dSpread = (double)value;
						break;
					case TAG_BenchmarkCurveCurrency:
						_sBenchmarkCurveCurrency = (string)value;
						break;
					case TAG_BenchmarkCurveName:
						_sBenchmarkCurveName = (string)value;
						break;
					case TAG_BenchmarkCurvePoint:
						_sBenchmarkCurvePoint = (string)value;
						break;
					case TAG_BenchmarkPrice:
						_dBenchmarkPrice = (double)value;
						break;
					case TAG_BenchmarkPriceType:
						_iBenchmarkPriceType = (int)value;
						break;
					case TAG_BenchmarkSecurityID:
						_sBenchmarkSecurityID = (string)value;
						break;
					case TAG_BenchmarkSecurityIDSource:
						_sBenchmarkSecurityIDSource = (string)value;
						break;
					case TAG_YieldType:
						_sYieldType = (string)value;
						break;
					case TAG_Yield:
						_dYield = (double)value;
						break;
					case TAG_YieldCalcDate:
						_dtYieldCalcDate = (DateTime)value;
						break;
					case TAG_YieldRedemptionDate:
						_dtYieldRedemptionDate = (DateTime)value;
						break;
					case TAG_YieldRedemptionPrice:
						_dYieldRedemptionPrice = (double)value;
						break;
					case TAG_YieldRedemptionPriceType:
						_iYieldRedemptionPriceType = (int)value;
						break;
					case TAG_Currency:
						_sCurrency = (string)value;
						break;
					case TAG_ComplianceID:
						_sComplianceID = (string)value;
						break;
					case TAG_IOIid:
						_sIOIid = (string)value;
						break;
					case TAG_QuoteID:
						_sQuoteID = (string)value;
						break;
					case TAG_TimeInForce:
						_cTimeInForce = (char)value;
						break;
					case TAG_EffectiveTime:
						_dtEffectiveTime = (DateTime)value;
						break;
					case TAG_ExpireDate:
						_dtExpireDate = (DateTime)value;
						break;
					case TAG_ExpireTime:
						_dtExpireTime = (DateTime)value;
						break;
					case TAG_GTBookingInst:
						_iGTBookingInst = (int)value;
						break;
					case TAG_MaxShow:
						_iMaxShow = (int)value;
						break;
					case TAG_PegOffsetValue:
						_dPegOffsetValue = (double)value;
						break;
					case TAG_PegMoveType:
						_iPegMoveType = (int)value;
						break;
					case TAG_PegOffsetType:
						_iPegOffsetType = (int)value;
						break;
					case TAG_PegLimitType:
						_iPegLimitType = (int)value;
						break;
					case TAG_PegRoundDirection:
						_iPegRoundDirection = (int)value;
						break;
					case TAG_PegScope:
						_iPegScope = (int)value;
						break;
					case TAG_DiscretionInst:
						_cDiscretionInst = (char)value;
						break;
					case TAG_DiscretionOffsetValue:
						_dDiscretionOffsetValue = (double)value;
						break;
					case TAG_DiscretionMoveType:
						_iDiscretionMoveType = (int)value;
						break;
					case TAG_DiscretionOffsetType:
						_iDiscretionOffsetType = (int)value;
						break;
					case TAG_DiscretionLimitType:
						_iDiscretionLimitType = (int)value;
						break;
					case TAG_DiscretionRoundDirection:
						_iDiscretionRoundDirection = (int)value;
						break;
					case TAG_DiscretionScope:
						_iDiscretionScope = (int)value;
						break;
					case TAG_TargetStrategy:
						_iTargetStrategy = (int)value;
						break;
					case TAG_TargetStrategyParameters:
						_sTargetStrategyParameters = (string)value;
						break;
					case TAG_ParticipationRate:
						_dParticipationRate = (double)value;
						break;
					case TAG_CancellationRights:
						_cCancellationRights = (char)value;
						break;
					case TAG_MoneyLaunderingStatus:
						_cMoneyLaunderingStatus = (char)value;
						break;
					case TAG_RegistID:
						_sRegistID = (string)value;
						break;
					case TAG_Designation:
						_sDesignation = (string)value;
						break;
					default:
						base[iTag] = value;
						break;
				}
			}
		}

	}

	public class NewOrderCrossSide
	{
		private char _cSide;
		private string _sClOrdID;
		private string _sSecondaryClOrdID;
		private string _sClOrdLinkID;
		private int _iNoPartyIDs;
		private NewOrderCrossPartyIDList _listPartyID = new NewOrderCrossPartyIDList();
		private DateTime _dtTradeOriginationDate;
		private DateTime _dtTradeDate;
		private string _sAccount;
		private int _iAcctIDSource;
		private int _iAccountType;
		private char _cDayBookingInst;
		private char _cBookingUnit;
		private char _cPreallocMethod;
		private string _sAllocID;
		private int _iNoAllocs;
		private NewOrderCrossAllocList _listAlloc = new NewOrderCrossAllocList();
		private int _iQtyType;
		private int _iOrderQty;
		private int _iCashOrderQty;
		private double _dOrderPercent;
		private char _cRoundingDirection;
		private double _dRoundingModulus;
		private double _dCommission;
		private char _cCommType;
		private string _sCommCurrency;
		private char _cFundRenewWaiv;
		private char _cOrderCapacity;
		private string _sOrderRestrictions;
		private int _iCustOrderCapacity;
		private bool _bForexReq;
		private string _sSettlCurrency;
		private int _iBookingType;
		private string _sText;
		private int _iEncodedTextLen;
		private string _sEncodedText;
		private char _cPositionEffect;
		private int _iCoveredOrUncovered;
		private char _cCashMargin;
		private string _sClearingFeeIndicator;
		private bool _bSolicitedFlag;
		private string _sSideComplianceID;

		public char Side
		{
			get { return _cSide; }
			set { _cSide = value; }
		}
		public string ClOrdID
		{
			get { return _sClOrdID; }
			set { _sClOrdID = value; }
		}
		public string SecondaryClOrdID
		{
			get { return _sSecondaryClOrdID; }
			set { _sSecondaryClOrdID = value; }
		}
		public string ClOrdLinkID
		{
			get { return _sClOrdLinkID; }
			set { _sClOrdLinkID = value; }
		}
		public int NoPartyIDs
		{
			get { return _iNoPartyIDs; }
			set { _iNoPartyIDs = value; }
		}
		public NewOrderCrossPartyIDList PartyID 
		{
			get { return _listPartyID; }
		}
		public DateTime TradeOriginationDate
		{
			get { return _dtTradeOriginationDate; }
			set { _dtTradeOriginationDate = value; }
		}
		public DateTime TradeDate
		{
			get { return _dtTradeDate; }
			set { _dtTradeDate = value; }
		}
		public string Account
		{
			get { return _sAccount; }
			set { _sAccount = value; }
		}
		public int AcctIDSource
		{
			get { return _iAcctIDSource; }
			set { _iAcctIDSource = value; }
		}
		public int AccountType
		{
			get { return _iAccountType; }
			set { _iAccountType = value; }
		}
		public char DayBookingInst
		{
			get { return _cDayBookingInst; }
			set { _cDayBookingInst = value; }
		}
		public char BookingUnit
		{
			get { return _cBookingUnit; }
			set { _cBookingUnit = value; }
		}
		public char PreallocMethod
		{
			get { return _cPreallocMethod; }
			set { _cPreallocMethod = value; }
		}
		public string AllocID
		{
			get { return _sAllocID; }
			set { _sAllocID = value; }
		}
		public int NoAllocs
		{
			get { return _iNoAllocs; }
			set { _iNoAllocs = value; }
		}
		public NewOrderCrossAllocList Alloc 
		{
			get { return _listAlloc; }
		}
		public int QtyType
		{
			get { return _iQtyType; }
			set { _iQtyType = value; }
		}
		public int OrderQty
		{
			get { return _iOrderQty; }
			set { _iOrderQty = value; }
		}
		public int CashOrderQty
		{
			get { return _iCashOrderQty; }
			set { _iCashOrderQty = value; }
		}
		public double OrderPercent
		{
			get { return _dOrderPercent; }
			set { _dOrderPercent = value; }
		}
		public char RoundingDirection
		{
			get { return _cRoundingDirection; }
			set { _cRoundingDirection = value; }
		}
		public double RoundingModulus
		{
			get { return _dRoundingModulus; }
			set { _dRoundingModulus = value; }
		}
		public double Commission
		{
			get { return _dCommission; }
			set { _dCommission = value; }
		}
		public char CommType
		{
			get { return _cCommType; }
			set { _cCommType = value; }
		}
		public string CommCurrency
		{
			get { return _sCommCurrency; }
			set { _sCommCurrency = value; }
		}
		public char FundRenewWaiv
		{
			get { return _cFundRenewWaiv; }
			set { _cFundRenewWaiv = value; }
		}
		public char OrderCapacity
		{
			get { return _cOrderCapacity; }
			set { _cOrderCapacity = value; }
		}
		public string OrderRestrictions
		{
			get { return _sOrderRestrictions; }
			set { _sOrderRestrictions = value; }
		}
		public int CustOrderCapacity
		{
			get { return _iCustOrderCapacity; }
			set { _iCustOrderCapacity = value; }
		}
		public bool ForexReq
		{
			get { return _bForexReq; }
			set { _bForexReq = value; }
		}
		public string SettlCurrency
		{
			get { return _sSettlCurrency; }
			set { _sSettlCurrency = value; }
		}
		public int BookingType
		{
			get { return _iBookingType; }
			set { _iBookingType = value; }
		}
		public string Text
		{
			get { return _sText; }
			set { _sText = value; }
		}
		public int EncodedTextLen
		{
			get { return _iEncodedTextLen; }
			set { _iEncodedTextLen = value; }
		}
		public string EncodedText
		{
			get { return _sEncodedText; }
			set { _sEncodedText = value; }
		}
		public char PositionEffect
		{
			get { return _cPositionEffect; }
			set { _cPositionEffect = value; }
		}
		public int CoveredOrUncovered
		{
			get { return _iCoveredOrUncovered; }
			set { _iCoveredOrUncovered = value; }
		}
		public char CashMargin
		{
			get { return _cCashMargin; }
			set { _cCashMargin = value; }
		}
		public string ClearingFeeIndicator
		{
			get { return _sClearingFeeIndicator; }
			set { _sClearingFeeIndicator = value; }
		}
		public bool SolicitedFlag
		{
			get { return _bSolicitedFlag; }
			set { _bSolicitedFlag = value; }
		}
		public string SideComplianceID
		{
			get { return _sSideComplianceID; }
			set { _sSideComplianceID = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_Side:
						return _cSide;
					case NewOrderCross.TAG_ClOrdID:
						return _sClOrdID;
					case NewOrderCross.TAG_SecondaryClOrdID:
						return _sSecondaryClOrdID;
					case NewOrderCross.TAG_ClOrdLinkID:
						return _sClOrdLinkID;
					case NewOrderCross.TAG_NoPartyIDs:
						return _iNoPartyIDs;
					case NewOrderCross.TAG_TradeOriginationDate:
						return _dtTradeOriginationDate;
					case NewOrderCross.TAG_TradeDate:
						return _dtTradeDate;
					case NewOrderCross.TAG_Account:
						return _sAccount;
					case NewOrderCross.TAG_AcctIDSource:
						return _iAcctIDSource;
					case NewOrderCross.TAG_AccountType:
						return _iAccountType;
					case NewOrderCross.TAG_DayBookingInst:
						return _cDayBookingInst;
					case NewOrderCross.TAG_BookingUnit:
						return _cBookingUnit;
					case NewOrderCross.TAG_PreallocMethod:
						return _cPreallocMethod;
					case NewOrderCross.TAG_AllocID:
						return _sAllocID;
					case NewOrderCross.TAG_NoAllocs:
						return _iNoAllocs;
					case NewOrderCross.TAG_QtyType:
						return _iQtyType;
					case NewOrderCross.TAG_OrderQty:
						return _iOrderQty;
					case NewOrderCross.TAG_CashOrderQty:
						return _iCashOrderQty;
					case NewOrderCross.TAG_OrderPercent:
						return _dOrderPercent;
					case NewOrderCross.TAG_RoundingDirection:
						return _cRoundingDirection;
					case NewOrderCross.TAG_RoundingModulus:
						return _dRoundingModulus;
					case NewOrderCross.TAG_Commission:
						return _dCommission;
					case NewOrderCross.TAG_CommType:
						return _cCommType;
					case NewOrderCross.TAG_CommCurrency:
						return _sCommCurrency;
					case NewOrderCross.TAG_FundRenewWaiv:
						return _cFundRenewWaiv;
					case NewOrderCross.TAG_OrderCapacity:
						return _cOrderCapacity;
					case NewOrderCross.TAG_OrderRestrictions:
						return _sOrderRestrictions;
					case NewOrderCross.TAG_CustOrderCapacity:
						return _iCustOrderCapacity;
					case NewOrderCross.TAG_ForexReq:
						return _bForexReq;
					case NewOrderCross.TAG_SettlCurrency:
						return _sSettlCurrency;
					case NewOrderCross.TAG_BookingType:
						return _iBookingType;
					case NewOrderCross.TAG_Text:
						return _sText;
					case NewOrderCross.TAG_EncodedTextLen:
						return _iEncodedTextLen;
					case NewOrderCross.TAG_EncodedText:
						return _sEncodedText;
					case NewOrderCross.TAG_PositionEffect:
						return _cPositionEffect;
					case NewOrderCross.TAG_CoveredOrUncovered:
						return _iCoveredOrUncovered;
					case NewOrderCross.TAG_CashMargin:
						return _cCashMargin;
					case NewOrderCross.TAG_ClearingFeeIndicator:
						return _sClearingFeeIndicator;
					case NewOrderCross.TAG_SolicitedFlag:
						return _bSolicitedFlag;
					case NewOrderCross.TAG_SideComplianceID:
						return _sSideComplianceID;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_Side:
						_cSide = (char)value;
						break;
					case NewOrderCross.TAG_ClOrdID:
						_sClOrdID = (string)value;
						break;
					case NewOrderCross.TAG_SecondaryClOrdID:
						_sSecondaryClOrdID = (string)value;
						break;
					case NewOrderCross.TAG_ClOrdLinkID:
						_sClOrdLinkID = (string)value;
						break;
					case NewOrderCross.TAG_NoPartyIDs:
						_iNoPartyIDs = (int)value;
						break;
					case NewOrderCross.TAG_TradeOriginationDate:
						_dtTradeOriginationDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_TradeDate:
						_dtTradeDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_Account:
						_sAccount = (string)value;
						break;
					case NewOrderCross.TAG_AcctIDSource:
						_iAcctIDSource = (int)value;
						break;
					case NewOrderCross.TAG_AccountType:
						_iAccountType = (int)value;
						break;
					case NewOrderCross.TAG_DayBookingInst:
						_cDayBookingInst = (char)value;
						break;
					case NewOrderCross.TAG_BookingUnit:
						_cBookingUnit = (char)value;
						break;
					case NewOrderCross.TAG_PreallocMethod:
						_cPreallocMethod = (char)value;
						break;
					case NewOrderCross.TAG_AllocID:
						_sAllocID = (string)value;
						break;
					case NewOrderCross.TAG_NoAllocs:
						_iNoAllocs = (int)value;
						break;
					case NewOrderCross.TAG_QtyType:
						_iQtyType = (int)value;
						break;
					case NewOrderCross.TAG_OrderQty:
						_iOrderQty = (int)value;
						break;
					case NewOrderCross.TAG_CashOrderQty:
						_iCashOrderQty = (int)value;
						break;
					case NewOrderCross.TAG_OrderPercent:
						_dOrderPercent = (double)value;
						break;
					case NewOrderCross.TAG_RoundingDirection:
						_cRoundingDirection = (char)value;
						break;
					case NewOrderCross.TAG_RoundingModulus:
						_dRoundingModulus = (double)value;
						break;
					case NewOrderCross.TAG_Commission:
						_dCommission = (double)value;
						break;
					case NewOrderCross.TAG_CommType:
						_cCommType = (char)value;
						break;
					case NewOrderCross.TAG_CommCurrency:
						_sCommCurrency = (string)value;
						break;
					case NewOrderCross.TAG_FundRenewWaiv:
						_cFundRenewWaiv = (char)value;
						break;
					case NewOrderCross.TAG_OrderCapacity:
						_cOrderCapacity = (char)value;
						break;
					case NewOrderCross.TAG_OrderRestrictions:
						_sOrderRestrictions = (string)value;
						break;
					case NewOrderCross.TAG_CustOrderCapacity:
						_iCustOrderCapacity = (int)value;
						break;
					case NewOrderCross.TAG_ForexReq:
						_bForexReq = (bool)value;
						break;
					case NewOrderCross.TAG_SettlCurrency:
						_sSettlCurrency = (string)value;
						break;
					case NewOrderCross.TAG_BookingType:
						_iBookingType = (int)value;
						break;
					case NewOrderCross.TAG_Text:
						_sText = (string)value;
						break;
					case NewOrderCross.TAG_EncodedTextLen:
						_iEncodedTextLen = (int)value;
						break;
					case NewOrderCross.TAG_EncodedText:
						_sEncodedText = (string)value;
						break;
					case NewOrderCross.TAG_PositionEffect:
						_cPositionEffect = (char)value;
						break;
					case NewOrderCross.TAG_CoveredOrUncovered:
						_iCoveredOrUncovered = (int)value;
						break;
					case NewOrderCross.TAG_CashMargin:
						_cCashMargin = (char)value;
						break;
					case NewOrderCross.TAG_ClearingFeeIndicator:
						_sClearingFeeIndicator = (string)value;
						break;
					case NewOrderCross.TAG_SolicitedFlag:
						_bSolicitedFlag = (bool)value;
						break;
					case NewOrderCross.TAG_SideComplianceID:
						_sSideComplianceID = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossSideList
	{
		private ArrayList _al;
		private NewOrderCrossSide _last;

		public NewOrderCrossSide this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossSide)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossSide item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossSide item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossSide Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossPartyID
	{
		private string _sPartyID;
		private char _cPartyIDSource;
		private int _iPartyRole;
		private int _iNoPartySubIDs;
		private NewOrderCrossPartySubIDList _listPartySubID = new NewOrderCrossPartySubIDList();

		public string PartyID
		{
			get { return _sPartyID; }
			set { _sPartyID = value; }
		}
		public char PartyIDSource
		{
			get { return _cPartyIDSource; }
			set { _cPartyIDSource = value; }
		}
		public int PartyRole
		{
			get { return _iPartyRole; }
			set { _iPartyRole = value; }
		}
		public int NoPartySubIDs
		{
			get { return _iNoPartySubIDs; }
			set { _iNoPartySubIDs = value; }
		}
		public NewOrderCrossPartySubIDList PartySubID 
		{
			get { return _listPartySubID; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_PartyID:
						return _sPartyID;
					case NewOrderCross.TAG_PartyIDSource:
						return _cPartyIDSource;
					case NewOrderCross.TAG_PartyRole:
						return _iPartyRole;
					case NewOrderCross.TAG_NoPartySubIDs:
						return _iNoPartySubIDs;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_PartyID:
						_sPartyID = (string)value;
						break;
					case NewOrderCross.TAG_PartyIDSource:
						_cPartyIDSource = (char)value;
						break;
					case NewOrderCross.TAG_PartyRole:
						_iPartyRole = (int)value;
						break;
					case NewOrderCross.TAG_NoPartySubIDs:
						_iNoPartySubIDs = (int)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossPartyIDList
	{
		private ArrayList _al;
		private NewOrderCrossPartyID _last;

		public NewOrderCrossPartyID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossPartyID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossPartyID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossPartyID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossPartyID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossPartySubID
	{
		private string _sPartySubID;
		private int _iPartySubIDType;

		public string PartySubID
		{
			get { return _sPartySubID; }
			set { _sPartySubID = value; }
		}
		public int PartySubIDType
		{
			get { return _iPartySubIDType; }
			set { _iPartySubIDType = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_PartySubID:
						return _sPartySubID;
					case NewOrderCross.TAG_PartySubIDType:
						return _iPartySubIDType;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_PartySubID:
						_sPartySubID = (string)value;
						break;
					case NewOrderCross.TAG_PartySubIDType:
						_iPartySubIDType = (int)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossPartySubIDList
	{
		private ArrayList _al;
		private NewOrderCrossPartySubID _last;

		public NewOrderCrossPartySubID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossPartySubID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossPartySubID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossPartySubID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossPartySubID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossAlloc
	{
		private string _sAllocAccount;
		private int _iAllocAcctIDSource;
		private string _sAllocSettlCurrency;
		private string _sIndividualAllocID;
		private int _iNoNestedPartyIDs;
		private NewOrderCrossNestedPartyIDList _listNestedPartyID = new NewOrderCrossNestedPartyIDList();
		private int _iAllocQty;

		public string AllocAccount
		{
			get { return _sAllocAccount; }
			set { _sAllocAccount = value; }
		}
		public int AllocAcctIDSource
		{
			get { return _iAllocAcctIDSource; }
			set { _iAllocAcctIDSource = value; }
		}
		public string AllocSettlCurrency
		{
			get { return _sAllocSettlCurrency; }
			set { _sAllocSettlCurrency = value; }
		}
		public string IndividualAllocID
		{
			get { return _sIndividualAllocID; }
			set { _sIndividualAllocID = value; }
		}
		public int NoNestedPartyIDs
		{
			get { return _iNoNestedPartyIDs; }
			set { _iNoNestedPartyIDs = value; }
		}
		public NewOrderCrossNestedPartyIDList NestedPartyID 
		{
			get { return _listNestedPartyID; }
		}
		public int AllocQty
		{
			get { return _iAllocQty; }
			set { _iAllocQty = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_AllocAccount:
						return _sAllocAccount;
					case NewOrderCross.TAG_AllocAcctIDSource:
						return _iAllocAcctIDSource;
					case NewOrderCross.TAG_AllocSettlCurrency:
						return _sAllocSettlCurrency;
					case NewOrderCross.TAG_IndividualAllocID:
						return _sIndividualAllocID;
					case NewOrderCross.TAG_NoNestedPartyIDs:
						return _iNoNestedPartyIDs;
					case NewOrderCross.TAG_AllocQty:
						return _iAllocQty;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_AllocAccount:
						_sAllocAccount = (string)value;
						break;
					case NewOrderCross.TAG_AllocAcctIDSource:
						_iAllocAcctIDSource = (int)value;
						break;
					case NewOrderCross.TAG_AllocSettlCurrency:
						_sAllocSettlCurrency = (string)value;
						break;
					case NewOrderCross.TAG_IndividualAllocID:
						_sIndividualAllocID = (string)value;
						break;
					case NewOrderCross.TAG_NoNestedPartyIDs:
						_iNoNestedPartyIDs = (int)value;
						break;
					case NewOrderCross.TAG_AllocQty:
						_iAllocQty = (int)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossAllocList
	{
		private ArrayList _al;
		private NewOrderCrossAlloc _last;

		public NewOrderCrossAlloc this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossAlloc)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossAlloc item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossAlloc item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossAlloc Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossNestedPartyID
	{
		private string _sNestedPartyID;
		private char _cNestedPartyIDSource;
		private int _iNestedPartyRole;
		private int _iNoNestedPartySubIDs;
		private NewOrderCrossNestedPartySubIDList _listNestedPartySubID = new NewOrderCrossNestedPartySubIDList();

		public string NestedPartyID
		{
			get { return _sNestedPartyID; }
			set { _sNestedPartyID = value; }
		}
		public char NestedPartyIDSource
		{
			get { return _cNestedPartyIDSource; }
			set { _cNestedPartyIDSource = value; }
		}
		public int NestedPartyRole
		{
			get { return _iNestedPartyRole; }
			set { _iNestedPartyRole = value; }
		}
		public int NoNestedPartySubIDs
		{
			get { return _iNoNestedPartySubIDs; }
			set { _iNoNestedPartySubIDs = value; }
		}
		public NewOrderCrossNestedPartySubIDList NestedPartySubID 
		{
			get { return _listNestedPartySubID; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_NestedPartyID:
						return _sNestedPartyID;
					case NewOrderCross.TAG_NestedPartyIDSource:
						return _cNestedPartyIDSource;
					case NewOrderCross.TAG_NestedPartyRole:
						return _iNestedPartyRole;
					case NewOrderCross.TAG_NoNestedPartySubIDs:
						return _iNoNestedPartySubIDs;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_NestedPartyID:
						_sNestedPartyID = (string)value;
						break;
					case NewOrderCross.TAG_NestedPartyIDSource:
						_cNestedPartyIDSource = (char)value;
						break;
					case NewOrderCross.TAG_NestedPartyRole:
						_iNestedPartyRole = (int)value;
						break;
					case NewOrderCross.TAG_NoNestedPartySubIDs:
						_iNoNestedPartySubIDs = (int)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossNestedPartyIDList
	{
		private ArrayList _al;
		private NewOrderCrossNestedPartyID _last;

		public NewOrderCrossNestedPartyID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossNestedPartyID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossNestedPartyID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossNestedPartyID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossNestedPartyID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossNestedPartySubID
	{
		private string _sNestedPartySubID;
		private int _iNestedPartySubIDType;

		public string NestedPartySubID
		{
			get { return _sNestedPartySubID; }
			set { _sNestedPartySubID = value; }
		}
		public int NestedPartySubIDType
		{
			get { return _iNestedPartySubIDType; }
			set { _iNestedPartySubIDType = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_NestedPartySubID:
						return _sNestedPartySubID;
					case NewOrderCross.TAG_NestedPartySubIDType:
						return _iNestedPartySubIDType;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_NestedPartySubID:
						_sNestedPartySubID = (string)value;
						break;
					case NewOrderCross.TAG_NestedPartySubIDType:
						_iNestedPartySubIDType = (int)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossNestedPartySubIDList
	{
		private ArrayList _al;
		private NewOrderCrossNestedPartySubID _last;

		public NewOrderCrossNestedPartySubID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossNestedPartySubID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossNestedPartySubID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossNestedPartySubID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossNestedPartySubID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossSecurityAltID
	{
		private string _sSecurityAltID;
		private string _sSecurityAltIDSource;

		public string SecurityAltID
		{
			get { return _sSecurityAltID; }
			set { _sSecurityAltID = value; }
		}
		public string SecurityAltIDSource
		{
			get { return _sSecurityAltIDSource; }
			set { _sSecurityAltIDSource = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_SecurityAltID:
						return _sSecurityAltID;
					case NewOrderCross.TAG_SecurityAltIDSource:
						return _sSecurityAltIDSource;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_SecurityAltID:
						_sSecurityAltID = (string)value;
						break;
					case NewOrderCross.TAG_SecurityAltIDSource:
						_sSecurityAltIDSource = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossSecurityAltIDList
	{
		private ArrayList _al;
		private NewOrderCrossSecurityAltID _last;

		public NewOrderCrossSecurityAltID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossSecurityAltID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossSecurityAltID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossSecurityAltID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossSecurityAltID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossEvent
	{
		private int _iEventType;
		private DateTime _dtEventDate;
		private double _dEventPx;
		private string _sEventText;

		public int EventType
		{
			get { return _iEventType; }
			set { _iEventType = value; }
		}
		public DateTime EventDate
		{
			get { return _dtEventDate; }
			set { _dtEventDate = value; }
		}
		public double EventPx
		{
			get { return _dEventPx; }
			set { _dEventPx = value; }
		}
		public string EventText
		{
			get { return _sEventText; }
			set { _sEventText = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_EventType:
						return _iEventType;
					case NewOrderCross.TAG_EventDate:
						return _dtEventDate;
					case NewOrderCross.TAG_EventPx:
						return _dEventPx;
					case NewOrderCross.TAG_EventText:
						return _sEventText;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_EventType:
						_iEventType = (int)value;
						break;
					case NewOrderCross.TAG_EventDate:
						_dtEventDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_EventPx:
						_dEventPx = (double)value;
						break;
					case NewOrderCross.TAG_EventText:
						_sEventText = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossEventList
	{
		private ArrayList _al;
		private NewOrderCrossEvent _last;

		public NewOrderCrossEvent this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossEvent)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossEvent item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossEvent item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossEvent Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossUnderlying
	{
		private string _sUnderlyingSymbol;
		private string _sUnderlyingSymbolSfx;
		private string _sUnderlyingSecurityID;
		private string _sUnderlyingSecurityIDSource;
		private int _iNoUnderlyingSecurityAltID;
		private NewOrderCrossUnderlyingSecurityAltIDList _listUnderlyingSecurityAltID = new NewOrderCrossUnderlyingSecurityAltIDList();
		private int _iUnderlyingProduct;
		private string _sUnderlyingCFICode;
		private string _sUnderlyingSecurityType;
		private string _sUnderlyingSecuritySubType;
		private DateTime _dtUnderlyingMaturityMonthYear;
		private DateTime _dtUnderlyingMaturityDate;
		private DateTime _dtUnderlyingCouponPaymentDate;
		private DateTime _dtUnderlyingIssueDate;
		private int _iUnderlyingRepoCollateralSecurityType;
		private int _iUnderlyingRepurchaseTerm;
		private double _dUnderlyingRepurchaseRate;
		private double _dUnderlyingFactor;
		private string _sUnderlyingCreditRating;
		private string _sUnderlyingInstrRegistry;
		private string _sUnderlyingCountryOfIssue;
		private string _sUnderlyingStateOrProvinceOfIssue;
		private string _sUnderlyingLocaleOfIssue;
		private DateTime _dtUnderlyingRedemptionDate;
		private double _dUnderlyingStrikePrice;
		private string _sUnderlyingStrikeCurrency;
		private char _cUnderlyingOptAttribute;
		private double _dUnderlyingContractMultiplier;
		private double _dUnderlyingCouponRate;
		private string _sUnderlyingSecurityExchange;
		private string _sUnderlyingIssuer;
		private int _iEncodedUnderlyingIssuerLen;
		private string _sEncodedUnderlyingIssuer;
		private string _sUnderlyingSecurityDesc;
		private int _iEncodedUnderlyingSecurityDescLen;
		private string _sEncodedUnderlyingSecurityDesc;
		private string _sUnderlyingCPProgram;
		private string _sUnderlyingCPRegType;
		private string _sUnderlyingCurrency;
		private int _iUnderlyingQty;
		private double _dUnderlyingPx;
		private double _dUnderlyingDirtyPrice;
		private double _dUnderlyingEndPrice;
		private double _dUnderlyingStartValue;
		private double _dUnderlyingCurrentValue;
		private double _dUnderlyingEndValue;

		public string UnderlyingSymbol
		{
			get { return _sUnderlyingSymbol; }
			set { _sUnderlyingSymbol = value; }
		}
		public string UnderlyingSymbolSfx
		{
			get { return _sUnderlyingSymbolSfx; }
			set { _sUnderlyingSymbolSfx = value; }
		}
		public string UnderlyingSecurityID
		{
			get { return _sUnderlyingSecurityID; }
			set { _sUnderlyingSecurityID = value; }
		}
		public string UnderlyingSecurityIDSource
		{
			get { return _sUnderlyingSecurityIDSource; }
			set { _sUnderlyingSecurityIDSource = value; }
		}
		public int NoUnderlyingSecurityAltID
		{
			get { return _iNoUnderlyingSecurityAltID; }
			set { _iNoUnderlyingSecurityAltID = value; }
		}
		public NewOrderCrossUnderlyingSecurityAltIDList UnderlyingSecurityAltID 
		{
			get { return _listUnderlyingSecurityAltID; }
		}
		public int UnderlyingProduct
		{
			get { return _iUnderlyingProduct; }
			set { _iUnderlyingProduct = value; }
		}
		public string UnderlyingCFICode
		{
			get { return _sUnderlyingCFICode; }
			set { _sUnderlyingCFICode = value; }
		}
		public string UnderlyingSecurityType
		{
			get { return _sUnderlyingSecurityType; }
			set { _sUnderlyingSecurityType = value; }
		}
		public string UnderlyingSecuritySubType
		{
			get { return _sUnderlyingSecuritySubType; }
			set { _sUnderlyingSecuritySubType = value; }
		}
		public DateTime UnderlyingMaturityMonthYear
		{
			get { return _dtUnderlyingMaturityMonthYear; }
			set { _dtUnderlyingMaturityMonthYear = value; }
		}
		public DateTime UnderlyingMaturityDate
		{
			get { return _dtUnderlyingMaturityDate; }
			set { _dtUnderlyingMaturityDate = value; }
		}
		public DateTime UnderlyingCouponPaymentDate
		{
			get { return _dtUnderlyingCouponPaymentDate; }
			set { _dtUnderlyingCouponPaymentDate = value; }
		}
		public DateTime UnderlyingIssueDate
		{
			get { return _dtUnderlyingIssueDate; }
			set { _dtUnderlyingIssueDate = value; }
		}
		public int UnderlyingRepoCollateralSecurityType
		{
			get { return _iUnderlyingRepoCollateralSecurityType; }
			set { _iUnderlyingRepoCollateralSecurityType = value; }
		}
		public int UnderlyingRepurchaseTerm
		{
			get { return _iUnderlyingRepurchaseTerm; }
			set { _iUnderlyingRepurchaseTerm = value; }
		}
		public double UnderlyingRepurchaseRate
		{
			get { return _dUnderlyingRepurchaseRate; }
			set { _dUnderlyingRepurchaseRate = value; }
		}
		public double UnderlyingFactor
		{
			get { return _dUnderlyingFactor; }
			set { _dUnderlyingFactor = value; }
		}
		public string UnderlyingCreditRating
		{
			get { return _sUnderlyingCreditRating; }
			set { _sUnderlyingCreditRating = value; }
		}
		public string UnderlyingInstrRegistry
		{
			get { return _sUnderlyingInstrRegistry; }
			set { _sUnderlyingInstrRegistry = value; }
		}
		public string UnderlyingCountryOfIssue
		{
			get { return _sUnderlyingCountryOfIssue; }
			set { _sUnderlyingCountryOfIssue = value; }
		}
		public string UnderlyingStateOrProvinceOfIssue
		{
			get { return _sUnderlyingStateOrProvinceOfIssue; }
			set { _sUnderlyingStateOrProvinceOfIssue = value; }
		}
		public string UnderlyingLocaleOfIssue
		{
			get { return _sUnderlyingLocaleOfIssue; }
			set { _sUnderlyingLocaleOfIssue = value; }
		}
		public DateTime UnderlyingRedemptionDate
		{
			get { return _dtUnderlyingRedemptionDate; }
			set { _dtUnderlyingRedemptionDate = value; }
		}
		public double UnderlyingStrikePrice
		{
			get { return _dUnderlyingStrikePrice; }
			set { _dUnderlyingStrikePrice = value; }
		}
		public string UnderlyingStrikeCurrency
		{
			get { return _sUnderlyingStrikeCurrency; }
			set { _sUnderlyingStrikeCurrency = value; }
		}
		public char UnderlyingOptAttribute
		{
			get { return _cUnderlyingOptAttribute; }
			set { _cUnderlyingOptAttribute = value; }
		}
		public double UnderlyingContractMultiplier
		{
			get { return _dUnderlyingContractMultiplier; }
			set { _dUnderlyingContractMultiplier = value; }
		}
		public double UnderlyingCouponRate
		{
			get { return _dUnderlyingCouponRate; }
			set { _dUnderlyingCouponRate = value; }
		}
		public string UnderlyingSecurityExchange
		{
			get { return _sUnderlyingSecurityExchange; }
			set { _sUnderlyingSecurityExchange = value; }
		}
		public string UnderlyingIssuer
		{
			get { return _sUnderlyingIssuer; }
			set { _sUnderlyingIssuer = value; }
		}
		public int EncodedUnderlyingIssuerLen
		{
			get { return _iEncodedUnderlyingIssuerLen; }
			set { _iEncodedUnderlyingIssuerLen = value; }
		}
		public string EncodedUnderlyingIssuer
		{
			get { return _sEncodedUnderlyingIssuer; }
			set { _sEncodedUnderlyingIssuer = value; }
		}
		public string UnderlyingSecurityDesc
		{
			get { return _sUnderlyingSecurityDesc; }
			set { _sUnderlyingSecurityDesc = value; }
		}
		public int EncodedUnderlyingSecurityDescLen
		{
			get { return _iEncodedUnderlyingSecurityDescLen; }
			set { _iEncodedUnderlyingSecurityDescLen = value; }
		}
		public string EncodedUnderlyingSecurityDesc
		{
			get { return _sEncodedUnderlyingSecurityDesc; }
			set { _sEncodedUnderlyingSecurityDesc = value; }
		}
		public string UnderlyingCPProgram
		{
			get { return _sUnderlyingCPProgram; }
			set { _sUnderlyingCPProgram = value; }
		}
		public string UnderlyingCPRegType
		{
			get { return _sUnderlyingCPRegType; }
			set { _sUnderlyingCPRegType = value; }
		}
		public string UnderlyingCurrency
		{
			get { return _sUnderlyingCurrency; }
			set { _sUnderlyingCurrency = value; }
		}
		public int UnderlyingQty
		{
			get { return _iUnderlyingQty; }
			set { _iUnderlyingQty = value; }
		}
		public double UnderlyingPx
		{
			get { return _dUnderlyingPx; }
			set { _dUnderlyingPx = value; }
		}
		public double UnderlyingDirtyPrice
		{
			get { return _dUnderlyingDirtyPrice; }
			set { _dUnderlyingDirtyPrice = value; }
		}
		public double UnderlyingEndPrice
		{
			get { return _dUnderlyingEndPrice; }
			set { _dUnderlyingEndPrice = value; }
		}
		public double UnderlyingStartValue
		{
			get { return _dUnderlyingStartValue; }
			set { _dUnderlyingStartValue = value; }
		}
		public double UnderlyingCurrentValue
		{
			get { return _dUnderlyingCurrentValue; }
			set { _dUnderlyingCurrentValue = value; }
		}
		public double UnderlyingEndValue
		{
			get { return _dUnderlyingEndValue; }
			set { _dUnderlyingEndValue = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_UnderlyingSymbol:
						return _sUnderlyingSymbol;
					case NewOrderCross.TAG_UnderlyingSymbolSfx:
						return _sUnderlyingSymbolSfx;
					case NewOrderCross.TAG_UnderlyingSecurityID:
						return _sUnderlyingSecurityID;
					case NewOrderCross.TAG_UnderlyingSecurityIDSource:
						return _sUnderlyingSecurityIDSource;
					case NewOrderCross.TAG_NoUnderlyingSecurityAltID:
						return _iNoUnderlyingSecurityAltID;
					case NewOrderCross.TAG_UnderlyingProduct:
						return _iUnderlyingProduct;
					case NewOrderCross.TAG_UnderlyingCFICode:
						return _sUnderlyingCFICode;
					case NewOrderCross.TAG_UnderlyingSecurityType:
						return _sUnderlyingSecurityType;
					case NewOrderCross.TAG_UnderlyingSecuritySubType:
						return _sUnderlyingSecuritySubType;
					case NewOrderCross.TAG_UnderlyingMaturityMonthYear:
						return _dtUnderlyingMaturityMonthYear;
					case NewOrderCross.TAG_UnderlyingMaturityDate:
						return _dtUnderlyingMaturityDate;
					case NewOrderCross.TAG_UnderlyingCouponPaymentDate:
						return _dtUnderlyingCouponPaymentDate;
					case NewOrderCross.TAG_UnderlyingIssueDate:
						return _dtUnderlyingIssueDate;
					case NewOrderCross.TAG_UnderlyingRepoCollateralSecurityType:
						return _iUnderlyingRepoCollateralSecurityType;
					case NewOrderCross.TAG_UnderlyingRepurchaseTerm:
						return _iUnderlyingRepurchaseTerm;
					case NewOrderCross.TAG_UnderlyingRepurchaseRate:
						return _dUnderlyingRepurchaseRate;
					case NewOrderCross.TAG_UnderlyingFactor:
						return _dUnderlyingFactor;
					case NewOrderCross.TAG_UnderlyingCreditRating:
						return _sUnderlyingCreditRating;
					case NewOrderCross.TAG_UnderlyingInstrRegistry:
						return _sUnderlyingInstrRegistry;
					case NewOrderCross.TAG_UnderlyingCountryOfIssue:
						return _sUnderlyingCountryOfIssue;
					case NewOrderCross.TAG_UnderlyingStateOrProvinceOfIssue:
						return _sUnderlyingStateOrProvinceOfIssue;
					case NewOrderCross.TAG_UnderlyingLocaleOfIssue:
						return _sUnderlyingLocaleOfIssue;
					case NewOrderCross.TAG_UnderlyingRedemptionDate:
						return _dtUnderlyingRedemptionDate;
					case NewOrderCross.TAG_UnderlyingStrikePrice:
						return _dUnderlyingStrikePrice;
					case NewOrderCross.TAG_UnderlyingStrikeCurrency:
						return _sUnderlyingStrikeCurrency;
					case NewOrderCross.TAG_UnderlyingOptAttribute:
						return _cUnderlyingOptAttribute;
					case NewOrderCross.TAG_UnderlyingContractMultiplier:
						return _dUnderlyingContractMultiplier;
					case NewOrderCross.TAG_UnderlyingCouponRate:
						return _dUnderlyingCouponRate;
					case NewOrderCross.TAG_UnderlyingSecurityExchange:
						return _sUnderlyingSecurityExchange;
					case NewOrderCross.TAG_UnderlyingIssuer:
						return _sUnderlyingIssuer;
					case NewOrderCross.TAG_EncodedUnderlyingIssuerLen:
						return _iEncodedUnderlyingIssuerLen;
					case NewOrderCross.TAG_EncodedUnderlyingIssuer:
						return _sEncodedUnderlyingIssuer;
					case NewOrderCross.TAG_UnderlyingSecurityDesc:
						return _sUnderlyingSecurityDesc;
					case NewOrderCross.TAG_EncodedUnderlyingSecurityDescLen:
						return _iEncodedUnderlyingSecurityDescLen;
					case NewOrderCross.TAG_EncodedUnderlyingSecurityDesc:
						return _sEncodedUnderlyingSecurityDesc;
					case NewOrderCross.TAG_UnderlyingCPProgram:
						return _sUnderlyingCPProgram;
					case NewOrderCross.TAG_UnderlyingCPRegType:
						return _sUnderlyingCPRegType;
					case NewOrderCross.TAG_UnderlyingCurrency:
						return _sUnderlyingCurrency;
					case NewOrderCross.TAG_UnderlyingQty:
						return _iUnderlyingQty;
					case NewOrderCross.TAG_UnderlyingPx:
						return _dUnderlyingPx;
					case NewOrderCross.TAG_UnderlyingDirtyPrice:
						return _dUnderlyingDirtyPrice;
					case NewOrderCross.TAG_UnderlyingEndPrice:
						return _dUnderlyingEndPrice;
					case NewOrderCross.TAG_UnderlyingStartValue:
						return _dUnderlyingStartValue;
					case NewOrderCross.TAG_UnderlyingCurrentValue:
						return _dUnderlyingCurrentValue;
					case NewOrderCross.TAG_UnderlyingEndValue:
						return _dUnderlyingEndValue;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_UnderlyingSymbol:
						_sUnderlyingSymbol = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSymbolSfx:
						_sUnderlyingSymbolSfx = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecurityID:
						_sUnderlyingSecurityID = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecurityIDSource:
						_sUnderlyingSecurityIDSource = (string)value;
						break;
					case NewOrderCross.TAG_NoUnderlyingSecurityAltID:
						_iNoUnderlyingSecurityAltID = (int)value;
						break;
					case NewOrderCross.TAG_UnderlyingProduct:
						_iUnderlyingProduct = (int)value;
						break;
					case NewOrderCross.TAG_UnderlyingCFICode:
						_sUnderlyingCFICode = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecurityType:
						_sUnderlyingSecurityType = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecuritySubType:
						_sUnderlyingSecuritySubType = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingMaturityMonthYear:
						_dtUnderlyingMaturityMonthYear = (DateTime)value;
						break;
					case NewOrderCross.TAG_UnderlyingMaturityDate:
						_dtUnderlyingMaturityDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_UnderlyingCouponPaymentDate:
						_dtUnderlyingCouponPaymentDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_UnderlyingIssueDate:
						_dtUnderlyingIssueDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_UnderlyingRepoCollateralSecurityType:
						_iUnderlyingRepoCollateralSecurityType = (int)value;
						break;
					case NewOrderCross.TAG_UnderlyingRepurchaseTerm:
						_iUnderlyingRepurchaseTerm = (int)value;
						break;
					case NewOrderCross.TAG_UnderlyingRepurchaseRate:
						_dUnderlyingRepurchaseRate = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingFactor:
						_dUnderlyingFactor = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingCreditRating:
						_sUnderlyingCreditRating = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingInstrRegistry:
						_sUnderlyingInstrRegistry = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingCountryOfIssue:
						_sUnderlyingCountryOfIssue = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingStateOrProvinceOfIssue:
						_sUnderlyingStateOrProvinceOfIssue = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingLocaleOfIssue:
						_sUnderlyingLocaleOfIssue = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingRedemptionDate:
						_dtUnderlyingRedemptionDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_UnderlyingStrikePrice:
						_dUnderlyingStrikePrice = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingStrikeCurrency:
						_sUnderlyingStrikeCurrency = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingOptAttribute:
						_cUnderlyingOptAttribute = (char)value;
						break;
					case NewOrderCross.TAG_UnderlyingContractMultiplier:
						_dUnderlyingContractMultiplier = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingCouponRate:
						_dUnderlyingCouponRate = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecurityExchange:
						_sUnderlyingSecurityExchange = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingIssuer:
						_sUnderlyingIssuer = (string)value;
						break;
					case NewOrderCross.TAG_EncodedUnderlyingIssuerLen:
						_iEncodedUnderlyingIssuerLen = (int)value;
						break;
					case NewOrderCross.TAG_EncodedUnderlyingIssuer:
						_sEncodedUnderlyingIssuer = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecurityDesc:
						_sUnderlyingSecurityDesc = (string)value;
						break;
					case NewOrderCross.TAG_EncodedUnderlyingSecurityDescLen:
						_iEncodedUnderlyingSecurityDescLen = (int)value;
						break;
					case NewOrderCross.TAG_EncodedUnderlyingSecurityDesc:
						_sEncodedUnderlyingSecurityDesc = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingCPProgram:
						_sUnderlyingCPProgram = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingCPRegType:
						_sUnderlyingCPRegType = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingCurrency:
						_sUnderlyingCurrency = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingQty:
						_iUnderlyingQty = (int)value;
						break;
					case NewOrderCross.TAG_UnderlyingPx:
						_dUnderlyingPx = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingDirtyPrice:
						_dUnderlyingDirtyPrice = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingEndPrice:
						_dUnderlyingEndPrice = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingStartValue:
						_dUnderlyingStartValue = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingCurrentValue:
						_dUnderlyingCurrentValue = (double)value;
						break;
					case NewOrderCross.TAG_UnderlyingEndValue:
						_dUnderlyingEndValue = (double)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossUnderlyingList
	{
		private ArrayList _al;
		private NewOrderCrossUnderlying _last;

		public NewOrderCrossUnderlying this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossUnderlying)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossUnderlying item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossUnderlying item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossUnderlying Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossUnderlyingSecurityAltID
	{
		private string _sUnderlyingSecurityAltID;
		private string _sUnderlyingSecurityAltIDSource;

		public string UnderlyingSecurityAltID
		{
			get { return _sUnderlyingSecurityAltID; }
			set { _sUnderlyingSecurityAltID = value; }
		}
		public string UnderlyingSecurityAltIDSource
		{
			get { return _sUnderlyingSecurityAltIDSource; }
			set { _sUnderlyingSecurityAltIDSource = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_UnderlyingSecurityAltID:
						return _sUnderlyingSecurityAltID;
					case NewOrderCross.TAG_UnderlyingSecurityAltIDSource:
						return _sUnderlyingSecurityAltIDSource;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_UnderlyingSecurityAltID:
						_sUnderlyingSecurityAltID = (string)value;
						break;
					case NewOrderCross.TAG_UnderlyingSecurityAltIDSource:
						_sUnderlyingSecurityAltIDSource = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossUnderlyingSecurityAltIDList
	{
		private ArrayList _al;
		private NewOrderCrossUnderlyingSecurityAltID _last;

		public NewOrderCrossUnderlyingSecurityAltID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossUnderlyingSecurityAltID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossUnderlyingSecurityAltID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossUnderlyingSecurityAltID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossUnderlyingSecurityAltID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossLeg
	{
		private string _sLegSymbol;
		private string _sLegSymbolSfx;
		private string _sLegSecurityID;
		private string _sLegSecurityIDSource;
		private int _iNoLegSecurityAltID;
		private NewOrderCrossLegSecurityAltIDList _listLegSecurityAltID = new NewOrderCrossLegSecurityAltIDList();
		private int _iLegProduct;
		private string _sLegCFICode;
		private string _sLegSecurityType;
		private string _sLegSecuritySubType;
		private DateTime _dtLegMaturityMonthYear;
		private DateTime _dtLegMaturityDate;
		private DateTime _dtLegCouponPaymentDate;
		private DateTime _dtLegIssueDate;
		private int _iLegRepoCollateralSecurityType;
		private int _iLegRepurchaseTerm;
		private double _dLegRepurchaseRate;
		private double _dLegFactor;
		private string _sLegCreditRating;
		private string _sLegInstrRegistry;
		private string _sLegCountryOfIssue;
		private string _sLegStateOrProvinceOfIssue;
		private string _sLegLocaleOfIssue;
		private DateTime _dtLegRedemptionDate;
		private double _dLegStrikePrice;
		private string _sLegStrikeCurrency;
		private char _cLegOptAttribute;
		private double _dLegContractMultiplier;
		private double _dLegCouponRate;
		private string _sLegSecurityExchange;
		private string _sLegIssuer;
		private int _iEncodedLegIssuerLen;
		private string _sEncodedLegIssuer;
		private string _sLegSecurityDesc;
		private int _iEncodedLegSecurityDescLen;
		private string _sEncodedLegSecurityDesc;
		private double _dLegRatioQty;
		private char _cLegSide;
		private string _sLegCurrency;
		private string _sLegPool;
		private DateTime _dtLegDatedDate;
		private DateTime _dtLegContractSettlMonth;
		private DateTime _dtLegInterestAccrualDate;

		public string LegSymbol
		{
			get { return _sLegSymbol; }
			set { _sLegSymbol = value; }
		}
		public string LegSymbolSfx
		{
			get { return _sLegSymbolSfx; }
			set { _sLegSymbolSfx = value; }
		}
		public string LegSecurityID
		{
			get { return _sLegSecurityID; }
			set { _sLegSecurityID = value; }
		}
		public string LegSecurityIDSource
		{
			get { return _sLegSecurityIDSource; }
			set { _sLegSecurityIDSource = value; }
		}
		public int NoLegSecurityAltID
		{
			get { return _iNoLegSecurityAltID; }
			set { _iNoLegSecurityAltID = value; }
		}
		public NewOrderCrossLegSecurityAltIDList LegSecurityAltID 
		{
			get { return _listLegSecurityAltID; }
		}
		public int LegProduct
		{
			get { return _iLegProduct; }
			set { _iLegProduct = value; }
		}
		public string LegCFICode
		{
			get { return _sLegCFICode; }
			set { _sLegCFICode = value; }
		}
		public string LegSecurityType
		{
			get { return _sLegSecurityType; }
			set { _sLegSecurityType = value; }
		}
		public string LegSecuritySubType
		{
			get { return _sLegSecuritySubType; }
			set { _sLegSecuritySubType = value; }
		}
		public DateTime LegMaturityMonthYear
		{
			get { return _dtLegMaturityMonthYear; }
			set { _dtLegMaturityMonthYear = value; }
		}
		public DateTime LegMaturityDate
		{
			get { return _dtLegMaturityDate; }
			set { _dtLegMaturityDate = value; }
		}
		public DateTime LegCouponPaymentDate
		{
			get { return _dtLegCouponPaymentDate; }
			set { _dtLegCouponPaymentDate = value; }
		}
		public DateTime LegIssueDate
		{
			get { return _dtLegIssueDate; }
			set { _dtLegIssueDate = value; }
		}
		public int LegRepoCollateralSecurityType
		{
			get { return _iLegRepoCollateralSecurityType; }
			set { _iLegRepoCollateralSecurityType = value; }
		}
		public int LegRepurchaseTerm
		{
			get { return _iLegRepurchaseTerm; }
			set { _iLegRepurchaseTerm = value; }
		}
		public double LegRepurchaseRate
		{
			get { return _dLegRepurchaseRate; }
			set { _dLegRepurchaseRate = value; }
		}
		public double LegFactor
		{
			get { return _dLegFactor; }
			set { _dLegFactor = value; }
		}
		public string LegCreditRating
		{
			get { return _sLegCreditRating; }
			set { _sLegCreditRating = value; }
		}
		public string LegInstrRegistry
		{
			get { return _sLegInstrRegistry; }
			set { _sLegInstrRegistry = value; }
		}
		public string LegCountryOfIssue
		{
			get { return _sLegCountryOfIssue; }
			set { _sLegCountryOfIssue = value; }
		}
		public string LegStateOrProvinceOfIssue
		{
			get { return _sLegStateOrProvinceOfIssue; }
			set { _sLegStateOrProvinceOfIssue = value; }
		}
		public string LegLocaleOfIssue
		{
			get { return _sLegLocaleOfIssue; }
			set { _sLegLocaleOfIssue = value; }
		}
		public DateTime LegRedemptionDate
		{
			get { return _dtLegRedemptionDate; }
			set { _dtLegRedemptionDate = value; }
		}
		public double LegStrikePrice
		{
			get { return _dLegStrikePrice; }
			set { _dLegStrikePrice = value; }
		}
		public string LegStrikeCurrency
		{
			get { return _sLegStrikeCurrency; }
			set { _sLegStrikeCurrency = value; }
		}
		public char LegOptAttribute
		{
			get { return _cLegOptAttribute; }
			set { _cLegOptAttribute = value; }
		}
		public double LegContractMultiplier
		{
			get { return _dLegContractMultiplier; }
			set { _dLegContractMultiplier = value; }
		}
		public double LegCouponRate
		{
			get { return _dLegCouponRate; }
			set { _dLegCouponRate = value; }
		}
		public string LegSecurityExchange
		{
			get { return _sLegSecurityExchange; }
			set { _sLegSecurityExchange = value; }
		}
		public string LegIssuer
		{
			get { return _sLegIssuer; }
			set { _sLegIssuer = value; }
		}
		public int EncodedLegIssuerLen
		{
			get { return _iEncodedLegIssuerLen; }
			set { _iEncodedLegIssuerLen = value; }
		}
		public string EncodedLegIssuer
		{
			get { return _sEncodedLegIssuer; }
			set { _sEncodedLegIssuer = value; }
		}
		public string LegSecurityDesc
		{
			get { return _sLegSecurityDesc; }
			set { _sLegSecurityDesc = value; }
		}
		public int EncodedLegSecurityDescLen
		{
			get { return _iEncodedLegSecurityDescLen; }
			set { _iEncodedLegSecurityDescLen = value; }
		}
		public string EncodedLegSecurityDesc
		{
			get { return _sEncodedLegSecurityDesc; }
			set { _sEncodedLegSecurityDesc = value; }
		}
		public double LegRatioQty
		{
			get { return _dLegRatioQty; }
			set { _dLegRatioQty = value; }
		}
		public char LegSide
		{
			get { return _cLegSide; }
			set { _cLegSide = value; }
		}
		public string LegCurrency
		{
			get { return _sLegCurrency; }
			set { _sLegCurrency = value; }
		}
		public string LegPool
		{
			get { return _sLegPool; }
			set { _sLegPool = value; }
		}
		public DateTime LegDatedDate
		{
			get { return _dtLegDatedDate; }
			set { _dtLegDatedDate = value; }
		}
		public DateTime LegContractSettlMonth
		{
			get { return _dtLegContractSettlMonth; }
			set { _dtLegContractSettlMonth = value; }
		}
		public DateTime LegInterestAccrualDate
		{
			get { return _dtLegInterestAccrualDate; }
			set { _dtLegInterestAccrualDate = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_LegSymbol:
						return _sLegSymbol;
					case NewOrderCross.TAG_LegSymbolSfx:
						return _sLegSymbolSfx;
					case NewOrderCross.TAG_LegSecurityID:
						return _sLegSecurityID;
					case NewOrderCross.TAG_LegSecurityIDSource:
						return _sLegSecurityIDSource;
					case NewOrderCross.TAG_NoLegSecurityAltID:
						return _iNoLegSecurityAltID;
					case NewOrderCross.TAG_LegProduct:
						return _iLegProduct;
					case NewOrderCross.TAG_LegCFICode:
						return _sLegCFICode;
					case NewOrderCross.TAG_LegSecurityType:
						return _sLegSecurityType;
					case NewOrderCross.TAG_LegSecuritySubType:
						return _sLegSecuritySubType;
					case NewOrderCross.TAG_LegMaturityMonthYear:
						return _dtLegMaturityMonthYear;
					case NewOrderCross.TAG_LegMaturityDate:
						return _dtLegMaturityDate;
					case NewOrderCross.TAG_LegCouponPaymentDate:
						return _dtLegCouponPaymentDate;
					case NewOrderCross.TAG_LegIssueDate:
						return _dtLegIssueDate;
					case NewOrderCross.TAG_LegRepoCollateralSecurityType:
						return _iLegRepoCollateralSecurityType;
					case NewOrderCross.TAG_LegRepurchaseTerm:
						return _iLegRepurchaseTerm;
					case NewOrderCross.TAG_LegRepurchaseRate:
						return _dLegRepurchaseRate;
					case NewOrderCross.TAG_LegFactor:
						return _dLegFactor;
					case NewOrderCross.TAG_LegCreditRating:
						return _sLegCreditRating;
					case NewOrderCross.TAG_LegInstrRegistry:
						return _sLegInstrRegistry;
					case NewOrderCross.TAG_LegCountryOfIssue:
						return _sLegCountryOfIssue;
					case NewOrderCross.TAG_LegStateOrProvinceOfIssue:
						return _sLegStateOrProvinceOfIssue;
					case NewOrderCross.TAG_LegLocaleOfIssue:
						return _sLegLocaleOfIssue;
					case NewOrderCross.TAG_LegRedemptionDate:
						return _dtLegRedemptionDate;
					case NewOrderCross.TAG_LegStrikePrice:
						return _dLegStrikePrice;
					case NewOrderCross.TAG_LegStrikeCurrency:
						return _sLegStrikeCurrency;
					case NewOrderCross.TAG_LegOptAttribute:
						return _cLegOptAttribute;
					case NewOrderCross.TAG_LegContractMultiplier:
						return _dLegContractMultiplier;
					case NewOrderCross.TAG_LegCouponRate:
						return _dLegCouponRate;
					case NewOrderCross.TAG_LegSecurityExchange:
						return _sLegSecurityExchange;
					case NewOrderCross.TAG_LegIssuer:
						return _sLegIssuer;
					case NewOrderCross.TAG_EncodedLegIssuerLen:
						return _iEncodedLegIssuerLen;
					case NewOrderCross.TAG_EncodedLegIssuer:
						return _sEncodedLegIssuer;
					case NewOrderCross.TAG_LegSecurityDesc:
						return _sLegSecurityDesc;
					case NewOrderCross.TAG_EncodedLegSecurityDescLen:
						return _iEncodedLegSecurityDescLen;
					case NewOrderCross.TAG_EncodedLegSecurityDesc:
						return _sEncodedLegSecurityDesc;
					case NewOrderCross.TAG_LegRatioQty:
						return _dLegRatioQty;
					case NewOrderCross.TAG_LegSide:
						return _cLegSide;
					case NewOrderCross.TAG_LegCurrency:
						return _sLegCurrency;
					case NewOrderCross.TAG_LegPool:
						return _sLegPool;
					case NewOrderCross.TAG_LegDatedDate:
						return _dtLegDatedDate;
					case NewOrderCross.TAG_LegContractSettlMonth:
						return _dtLegContractSettlMonth;
					case NewOrderCross.TAG_LegInterestAccrualDate:
						return _dtLegInterestAccrualDate;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_LegSymbol:
						_sLegSymbol = (string)value;
						break;
					case NewOrderCross.TAG_LegSymbolSfx:
						_sLegSymbolSfx = (string)value;
						break;
					case NewOrderCross.TAG_LegSecurityID:
						_sLegSecurityID = (string)value;
						break;
					case NewOrderCross.TAG_LegSecurityIDSource:
						_sLegSecurityIDSource = (string)value;
						break;
					case NewOrderCross.TAG_NoLegSecurityAltID:
						_iNoLegSecurityAltID = (int)value;
						break;
					case NewOrderCross.TAG_LegProduct:
						_iLegProduct = (int)value;
						break;
					case NewOrderCross.TAG_LegCFICode:
						_sLegCFICode = (string)value;
						break;
					case NewOrderCross.TAG_LegSecurityType:
						_sLegSecurityType = (string)value;
						break;
					case NewOrderCross.TAG_LegSecuritySubType:
						_sLegSecuritySubType = (string)value;
						break;
					case NewOrderCross.TAG_LegMaturityMonthYear:
						_dtLegMaturityMonthYear = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegMaturityDate:
						_dtLegMaturityDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegCouponPaymentDate:
						_dtLegCouponPaymentDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegIssueDate:
						_dtLegIssueDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegRepoCollateralSecurityType:
						_iLegRepoCollateralSecurityType = (int)value;
						break;
					case NewOrderCross.TAG_LegRepurchaseTerm:
						_iLegRepurchaseTerm = (int)value;
						break;
					case NewOrderCross.TAG_LegRepurchaseRate:
						_dLegRepurchaseRate = (double)value;
						break;
					case NewOrderCross.TAG_LegFactor:
						_dLegFactor = (double)value;
						break;
					case NewOrderCross.TAG_LegCreditRating:
						_sLegCreditRating = (string)value;
						break;
					case NewOrderCross.TAG_LegInstrRegistry:
						_sLegInstrRegistry = (string)value;
						break;
					case NewOrderCross.TAG_LegCountryOfIssue:
						_sLegCountryOfIssue = (string)value;
						break;
					case NewOrderCross.TAG_LegStateOrProvinceOfIssue:
						_sLegStateOrProvinceOfIssue = (string)value;
						break;
					case NewOrderCross.TAG_LegLocaleOfIssue:
						_sLegLocaleOfIssue = (string)value;
						break;
					case NewOrderCross.TAG_LegRedemptionDate:
						_dtLegRedemptionDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegStrikePrice:
						_dLegStrikePrice = (double)value;
						break;
					case NewOrderCross.TAG_LegStrikeCurrency:
						_sLegStrikeCurrency = (string)value;
						break;
					case NewOrderCross.TAG_LegOptAttribute:
						_cLegOptAttribute = (char)value;
						break;
					case NewOrderCross.TAG_LegContractMultiplier:
						_dLegContractMultiplier = (double)value;
						break;
					case NewOrderCross.TAG_LegCouponRate:
						_dLegCouponRate = (double)value;
						break;
					case NewOrderCross.TAG_LegSecurityExchange:
						_sLegSecurityExchange = (string)value;
						break;
					case NewOrderCross.TAG_LegIssuer:
						_sLegIssuer = (string)value;
						break;
					case NewOrderCross.TAG_EncodedLegIssuerLen:
						_iEncodedLegIssuerLen = (int)value;
						break;
					case NewOrderCross.TAG_EncodedLegIssuer:
						_sEncodedLegIssuer = (string)value;
						break;
					case NewOrderCross.TAG_LegSecurityDesc:
						_sLegSecurityDesc = (string)value;
						break;
					case NewOrderCross.TAG_EncodedLegSecurityDescLen:
						_iEncodedLegSecurityDescLen = (int)value;
						break;
					case NewOrderCross.TAG_EncodedLegSecurityDesc:
						_sEncodedLegSecurityDesc = (string)value;
						break;
					case NewOrderCross.TAG_LegRatioQty:
						_dLegRatioQty = (double)value;
						break;
					case NewOrderCross.TAG_LegSide:
						_cLegSide = (char)value;
						break;
					case NewOrderCross.TAG_LegCurrency:
						_sLegCurrency = (string)value;
						break;
					case NewOrderCross.TAG_LegPool:
						_sLegPool = (string)value;
						break;
					case NewOrderCross.TAG_LegDatedDate:
						_dtLegDatedDate = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegContractSettlMonth:
						_dtLegContractSettlMonth = (DateTime)value;
						break;
					case NewOrderCross.TAG_LegInterestAccrualDate:
						_dtLegInterestAccrualDate = (DateTime)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossLegList
	{
		private ArrayList _al;
		private NewOrderCrossLeg _last;

		public NewOrderCrossLeg this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossLeg)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossLeg item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossLeg item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossLeg Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossLegSecurityAltID
	{
		private string _sLegSecurityAltID;
		private string _sLegSecurityAltIDSource;

		public string LegSecurityAltID
		{
			get { return _sLegSecurityAltID; }
			set { _sLegSecurityAltID = value; }
		}
		public string LegSecurityAltIDSource
		{
			get { return _sLegSecurityAltIDSource; }
			set { _sLegSecurityAltIDSource = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_LegSecurityAltID:
						return _sLegSecurityAltID;
					case NewOrderCross.TAG_LegSecurityAltIDSource:
						return _sLegSecurityAltIDSource;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_LegSecurityAltID:
						_sLegSecurityAltID = (string)value;
						break;
					case NewOrderCross.TAG_LegSecurityAltIDSource:
						_sLegSecurityAltIDSource = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossLegSecurityAltIDList
	{
		private ArrayList _al;
		private NewOrderCrossLegSecurityAltID _last;

		public NewOrderCrossLegSecurityAltID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossLegSecurityAltID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossLegSecurityAltID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossLegSecurityAltID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossLegSecurityAltID Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossTradingSession
	{
		private string _sTradingSessionID;
		private string _sTradingSessionSubID;

		public string TradingSessionID
		{
			get { return _sTradingSessionID; }
			set { _sTradingSessionID = value; }
		}
		public string TradingSessionSubID
		{
			get { return _sTradingSessionSubID; }
			set { _sTradingSessionSubID = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_TradingSessionID:
						return _sTradingSessionID;
					case NewOrderCross.TAG_TradingSessionSubID:
						return _sTradingSessionSubID;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_TradingSessionID:
						_sTradingSessionID = (string)value;
						break;
					case NewOrderCross.TAG_TradingSessionSubID:
						_sTradingSessionSubID = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossTradingSessionList
	{
		private ArrayList _al;
		private NewOrderCrossTradingSession _last;

		public NewOrderCrossTradingSession this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossTradingSession)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossTradingSession item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossTradingSession item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossTradingSession Last
		{
			get { return _last; }
		}
	}

	public class NewOrderCrossStipulation
	{
		private string _sStipulationType;
		private string _sStipulationValue;

		public string StipulationType
		{
			get { return _sStipulationType; }
			set { _sStipulationType = value; }
		}
		public string StipulationValue
		{
			get { return _sStipulationValue; }
			set { _sStipulationValue = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_StipulationType:
						return _sStipulationType;
					case NewOrderCross.TAG_StipulationValue:
						return _sStipulationValue;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case NewOrderCross.TAG_StipulationType:
						_sStipulationType = (string)value;
						break;
					case NewOrderCross.TAG_StipulationValue:
						_sStipulationValue = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class NewOrderCrossStipulationList
	{
		private ArrayList _al;
		private NewOrderCrossStipulation _last;

		public NewOrderCrossStipulation this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (NewOrderCrossStipulation)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(NewOrderCrossStipulation item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(NewOrderCrossStipulation item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public NewOrderCrossStipulation Last
		{
			get { return _last; }
		}
	}
}
