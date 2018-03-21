﻿using Newtonsoft.Json;

namespace Bitmex.NET.Dtos
{
	public class InstrumentDto
	{
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("rootSymbol")]
		public string RootSymbol { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("typ")]
		public string Typ { get; set; }

		[JsonProperty("listing")]
		public System.DateTimeOffset? Listing { get; set; }

		[JsonProperty("front")]
		public System.DateTimeOffset? Front { get; set; }

		[JsonProperty("expiry")]
		public System.DateTimeOffset? Expiry { get; set; }

		[JsonProperty("settle")]
		public System.DateTimeOffset? Settle { get; set; }

		[JsonProperty("relistInterval")]
		public System.DateTimeOffset? RelistInterval { get; set; }

		[JsonProperty("inverseLeg")]
		public string InverseLeg { get; set; }

		[JsonProperty("sellLeg")]
		public string SellLeg { get; set; }

		[JsonProperty("buyLeg")]
		public string BuyLeg { get; set; }

		[JsonProperty("optionStrikePcnt")]
		public long? OptionStrikePcnt { get; set; }

		[JsonProperty("optionStrikeRound")]
		public long? OptionStrikeRound { get; set; }

		[JsonProperty("optionStrikePrice")]
		public long? OptionStrikePrice { get; set; }

		[JsonProperty("optionMultiplier")]
		public long? OptionMultiplier { get; set; }

		[JsonProperty("positionCurrency")]
		public string PositionCurrency { get; set; }

		[JsonProperty("underlying")]
		public string Underlying { get; set; }

		[JsonProperty("quoteCurrency")]
		public string QuoteCurrency { get; set; }

		[JsonProperty("underlyingSymbol")]
		public string UnderlyingSymbol { get; set; }

		[JsonProperty("reference")]
		public string Reference { get; set; }

		[JsonProperty("referenceSymbol")]
		public string ReferenceSymbol { get; set; }

		[JsonProperty("calcInterval")]
		public System.DateTimeOffset? CalcInterval { get; set; }

		[JsonProperty("publishInterval")]
		public System.DateTimeOffset? PublishInterval { get; set; }

		[JsonProperty("publishTime")]
		public System.DateTimeOffset? PublishTime { get; set; }

		[JsonProperty("maxOrderQty")]
		public long? MaxOrderQty { get; set; }

		[JsonProperty("maxPrice")]
		public long? MaxPrice { get; set; }

		[JsonProperty("lotSize")]
		public long? LotSize { get; set; }

		[JsonProperty("tickSize")]
		public long? TickSize { get; set; }

		[JsonProperty("multiplier")]
		public long? Multiplier { get; set; }

		[JsonProperty("settlCurrency")]
		public string SettlCurrency { get; set; }

		[JsonProperty("underlyingToPositionMultiplier")]
		public long? UnderlyingToPositionMultiplier { get; set; }

		[JsonProperty("underlyingToSettleMultiplier")]
		public long? UnderlyingToSettleMultiplier { get; set; }

		[JsonProperty("quoteToSettleMultiplier")]
		public long? QuoteToSettleMultiplier { get; set; }

		[JsonProperty("isQuanto")]
		public bool? IsQuanto { get; set; }

		[JsonProperty("isInverse")]
		public bool? IsInverse { get; set; }

		[JsonProperty("initMargin")]
		public long? InitMargin { get; set; }

		[JsonProperty("maintMargin")]
		public long? MaintMargin { get; set; }

		[JsonProperty("riskLimit")]
		public long? RiskLimit { get; set; }

		[JsonProperty("riskStep")]
		public long? RiskStep { get; set; }

		[JsonProperty("limit")]
		public long? Limit { get; set; }

		[JsonProperty("capped")]
		public bool? Capped { get; set; }

		[JsonProperty("taxed")]
		public bool? Taxed { get; set; }

		[JsonProperty("deleverage")]
		public bool? Deleverage { get; set; }

		[JsonProperty("makerFee")]
		public long? MakerFee { get; set; }

		[JsonProperty("takerFee")]
		public long? TakerFee { get; set; }

		[JsonProperty("settlementFee")]
		public long? SettlementFee { get; set; }

		[JsonProperty("insuranceFee")]
		public long? InsuranceFee { get; set; }

		[JsonProperty("fundingBaseSymbol")]
		public string FundingBaseSymbol { get; set; }

		[JsonProperty("fundingQuoteSymbol")]
		public string FundingQuoteSymbol { get; set; }

		[JsonProperty("fundingPremiumSymbol")]
		public string FundingPremiumSymbol { get; set; }

		[JsonProperty("fundingTimestamp")]
		public System.DateTimeOffset? FundingTimestamp { get; set; }

		[JsonProperty("fundingInterval")]
		public System.DateTimeOffset? FundingInterval { get; set; }

		[JsonProperty("fundingRate")]
		public long? FundingRate { get; set; }

		[JsonProperty("indicativeFundingRate")]
		public long? IndicativeFundingRate { get; set; }

		[JsonProperty("rebalanceTimestamp")]
		public System.DateTimeOffset? RebalanceTimestamp { get; set; }

		[JsonProperty("rebalanceInterval")]
		public System.DateTimeOffset? RebalanceInterval { get; set; }

		[JsonProperty("openingTimestamp")]
		public System.DateTimeOffset? OpeningTimestamp { get; set; }

		[JsonProperty("closingTimestamp")]
		public System.DateTimeOffset? ClosingTimestamp { get; set; }

		[JsonProperty("sessionInterval")]
		public System.DateTimeOffset? SessionInterval { get; set; }

		[JsonProperty("prevClosePrice")]
		public long? PrevClosePrice { get; set; }

		[JsonProperty("limitDownPrice")]
		public long? LimitDownPrice { get; set; }

		[JsonProperty("limitUpPrice")]
		public long? LimitUpPrice { get; set; }

		[JsonProperty("bankruptLimitDownPrice")]
		public long? BankruptLimitDownPrice { get; set; }

		[JsonProperty("bankruptLimitUpPrice")]
		public long? BankruptLimitUpPrice { get; set; }

		[JsonProperty("prevTotalVolume")]
		public long? PrevTotalVolume { get; set; }

		[JsonProperty("totalVolume")]
		public long? TotalVolume { get; set; }

		[JsonProperty("volume")]
		public long? Volume { get; set; }

		[JsonProperty("volume24h")]
		public long? Volume24H { get; set; }

		[JsonProperty("prevTotalTurnover")]
		public long? PrevTotalTurnover { get; set; }

		[JsonProperty("totalTurnover")]
		public long? TotalTurnover { get; set; }

		[JsonProperty("turnover")]
		public long? Turnover { get; set; }

		[JsonProperty("turnover24h")]
		public long? Turnover24H { get; set; }

		[JsonProperty("prevPrice24h")]
		public long? PrevPrice24H { get; set; }

		[JsonProperty("vwap")]
		public long? Vwap { get; set; }

		[JsonProperty("highPrice")]
		public long? HighPrice { get; set; }

		[JsonProperty("lowPrice")]
		public long? LowPrice { get; set; }

		[JsonProperty("lastPrice")]
		public long? LastPrice { get; set; }

		[JsonProperty("lastPriceProtected")]
		public long? LastPriceProtected { get; set; }

		[JsonProperty("lastTickDirection")]
		public string LastTickDirection { get; set; }

		[JsonProperty("lastChangePcnt")]
		public long? LastChangePcnt { get; set; }

		[JsonProperty("bidPrice")]
		public long? BidPrice { get; set; }

		[JsonProperty("midPrice")]
		public long? MidPrice { get; set; }

		[JsonProperty("askPrice")]
		public long? AskPrice { get; set; }

		[JsonProperty("impactBidPrice")]
		public long? ImpactBidPrice { get; set; }

		[JsonProperty("impactMidPrice")]
		public long? ImpactMidPrice { get; set; }

		[JsonProperty("impactAskPrice")]
		public long? ImpactAskPrice { get; set; }

		[JsonProperty("hasLiquidity")]
		public bool? HasLiquidity { get; set; }

		[JsonProperty("openInterest")]
		public long? OpenInterest { get; set; }

		[JsonProperty("openValue")]
		public long? OpenValue { get; set; }

		[JsonProperty("fairMethod")]
		public string FairMethod { get; set; }

		[JsonProperty("fairBasisRate")]
		public long? FairBasisRate { get; set; }

		[JsonProperty("fairBasis")]
		public long? FairBasis { get; set; }

		[JsonProperty("fairPrice")]
		public long? FairPrice { get; set; }

		[JsonProperty("markMethod")]
		public string MarkMethod { get; set; }

		[JsonProperty("markPrice")]
		public long? MarkPrice { get; set; }

		[JsonProperty("indicativeTaxRate")]
		public long? IndicativeTaxRate { get; set; }

		[JsonProperty("indicativeSettlePrice")]
		public long? IndicativeSettlePrice { get; set; }

		[JsonProperty("optionUnderlyingPrice")]
		public long? OptionUnderlyingPrice { get; set; }

		[JsonProperty("settledPrice")]
		public long? SettledPrice { get; set; }

		[JsonProperty("timestamp")]
		public System.DateTimeOffset? Timestamp { get; set; }
	}
}
