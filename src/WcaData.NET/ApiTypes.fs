module WcaData.ApiTypes

open System

// fsharplint:disable RecordFieldNames

type Avatar = {
  url: string
  thumb_url: string
  is_default: bool
}

type Team = {

  uknown: string
}

type User = {
  ``class``: string
  url: string
  id: uint32
  wca_id: string
  name: string
  gender: string
  country_iso2: string
  delegate_status: string
  created_at: DateTime
  updated_at: DateTime
  teams: Team list
  avatar: Avatar
}

type GetUser = {
  user: User
}

type RecordTimes = {
  single: uint32
  average: uint32
}

type GetRecords = {
  world_records: Map<string, RecordTimes>
  continental_records: Map<string, Map<string, RecordTimes>>
  national_records: Map<string, Map<string, RecordTimes>>
}